using NUnit.Framework;
using Bank;

namespace AccountTests
{
    [TestFixture]
    public class AccountTests
    {
        Account destination;
        Account myAccount;
        [SetUp]
        public void InitAccounts()
        {
            Account destination = new Account();
            Account myAccount = new Account();

        }

        [Test]
        public static void MyAccount_ShouldReturnDefaultBalance0_WhenBalanceCalled()
        {
            Account myAccount = new Account();
            Assert.AreEqual(0, myAccount.Balance);
        }
        [Test]
        public static void MyAccount_ShouldReturnDefaultBalance10_WhenInput10()
        {
            Account myAccount = new Account(10);
            Assert.AreEqual(10, myAccount.Balance);
        }

        [Test]
        public static void MyAccount_ShouldReturnBalance30_WhenWithdraw20From50()
        {
            Account myAccount = new Account(50);
            myAccount.Withdraw(30);
            Assert.AreEqual(20, myAccount.Balance);
        }
    }
}
