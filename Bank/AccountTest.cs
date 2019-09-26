using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    [TestFixture]

    class AccountTest
    {
        Account source;
        Account destination;

        [SetUp]
        public void InitAccount()
        {
            source = new Account();
            source.Deposit(200);
            destination = new Account();
            destination.Deposit(150);
        }
    }
}
