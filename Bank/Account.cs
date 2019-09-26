using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Account
    {
        private float balance;
        private float minBalance = 50;

        public Account()
        {

        }

        public Account(int value)
        {
            balance = value;
        }

        public float Balance
        {
            get { return balance;  }
        }

        public float MinBalance
        {
            get { return minBalance; }
        }
    }
}
