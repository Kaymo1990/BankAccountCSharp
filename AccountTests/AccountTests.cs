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
        public static void MyAccount_ShouldReturnDefaultBalance10_WhenDepositInput10()
        {
            Account myAccount = new Account();
            myAccount.Deposit(10);
            Assert.AreEqual(10, myAccount.Balance);
        }
    }
}
