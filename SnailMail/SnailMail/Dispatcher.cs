using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailMail
{
    public class Dispatcher
    {
        private List<Batch> batches = new List<Batch>();
        private int zipCode;

        /// <summary>
        /// Put the passed mail into a batch for its target zone.
        /// </summary>
        /// <param name="mail"></param>
        public void Dispatch(Mail mail)
        {
            zipCode = mail.ZipCode;
            if (batches.Count < 1)
            {
               Batch batch = new Batch(TargetZone);
                batch.AddMail(mail);
                batches.Add(batch);
            }
            else {
                bool check = false;
                foreach (Batch item in batches)
                {
                    if (item.TargetZone == TargetZone)
                    {
                        item.AddMail(mail);
                        check = true;

                    }
                }
                if (!check)
                {
                    Batch batch = new Batch(TargetZone);
                    batch.AddMail(mail);
                    batches.Add(batch);
                }
            }
        }

        /// <summary>
        /// Return the batch that targets the desired zone.
        /// </summary>
        /// <param name="zone">The desired zone number</param>
        /// <returns>
        /// The matching batch. Throws an NoBatchException if there's none for the passed zone.
        /// </returns>
        public Batch BatchFor(int zone)
        {
            Batch verify = new Batch(zone);
            foreach (Batch item in batches)
            {
                if (item.TargetZone == zone)
                {
                    verify = item;
                }
            }
            if (verify.Count < 1) throw new NoBatchException();
            else return verify ;
        }
        private int TargetZone
        {
            get { return zipCode / 1000; }
        }
    }
}
