using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class RecurringPayment
    {
        private Account account;
        private double amount;
        private DateTime firstOccurence;
        private TimeSpan recurringDuring;
        public RecurringPayment(Account account,double amount)
        {

        }
        public DateTime FirstOccurence
        {
            get { return firstOccurence; }
            set { firstOccurence = value; }
        }
        
        public TimeSpan RecurringDuration
        {
            get
            {
                return recurringDuring;
            }
            set
            {
                recurringDuring = value;
            }
        }
       public void TriggerPayment(DateTime dueDate)
        {

        }

    }
}
