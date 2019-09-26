using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Account
    {
        private float balance;
        private readonly float minBalance = 50;

        public Account()
        {

        }

        public Account(int value)
        {
            balance = value;
        }

        public void Deposit(float amount)
        {
            balance += amount;
        }

        public void Withdraw(float amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account destination, float amount)
        {
            destination.Deposit(amount);
            Withdraw(amount);
        }

        public Account TransferMinFunds(Account destination, float amount)
        {
            if ((Balance - amount) > MinBalance)
            {
                TransferFunds(destination, amount);
            }

            else
            {
                //throw new NotEnoughFundsException();
            }

            return destination;
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
