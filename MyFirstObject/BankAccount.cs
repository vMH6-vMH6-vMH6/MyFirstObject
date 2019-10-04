using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstObject
{
    class BankAccount
    {

        private string customername;
        private float balance;

        public string CustomerName
            {
                get {return customername;}
                set {customername = value;}
            }
        public float Balance
            {
                get { return balance; }
                set { balance = value; }
            }
        public float NewBalance (float deposit)
            {
                float newbalance;
                newbalance = this.balance + deposit;
                return newbalance;
            }

    }////////////////
}
