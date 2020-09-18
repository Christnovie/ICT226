using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailMail
{
    public class Batch
    {
        private List<Mail> mails;
      
        private int targetZone;
        /// <summary>
        /// Creates a batch
        /// </summary>
        /// <param name="targetZone">
        /// The zone number in which this batch will be sent, from 1 to 4.
        /// Throws a InvalidZoneNumberException when not in this range.
        /// </param>
        
        public Batch(int targetZone)
        {
            mails = new List<Mail>();
            this.targetZone = targetZone;
            if ((TargetZone < 1) || (TargetZone > 4)) { throw new InvalidZoneNumberException(); }
            
        }
        public int TargetZone
        {
            get { return targetZone; }
        }
        public void AddMail(Mail mail)
        {
            if (TargetZone != mail.ZipCode / 1000) throw new InvalidZoneNumberException();
            else
            mails.Add(mail);
        }
        public int Count
        {
            get { return mails.Count; }
        }
    }
}
