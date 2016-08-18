using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace FabrikamFiberSupportTest_nUnit
{
    public class Account
    {
        private decimal balance;
        private decimal minimumBalance = 10m;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account destination, decimal amount)
        {
            if (balance - amount < minimumBalance)
                throw new InsufficientFundsException();

            destination.Deposit(amount);

            Withdraw(amount);
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public decimal MinimumBalance
        {
            get { return minimumBalance; }
        }
    }

    public class InsufficientFundsException : ApplicationException
    {
    }

    [TestFixture,]
    [Category("LongSuite")]
    [Category("CriticalSuite")]
    //[Culture("fr-FR-suite")]
    public class AccountTest
    {
        Account source;
        Account destination;

        [SetUp]
        public void Init()
        {
            source = new Account();
            source.Deposit(200m);

            destination = new Account();
            destination.Deposit(150m);
        }

        [Test]
        [Category("AllSuite")]
        public void TransferFunds()
        {
            source.TransferFunds(destination, 100m);

            Assert.AreEqual(250m, destination.Balance);
            Assert.AreEqual(100m, source.Balance);
        }

        [Test, Description("Given a non-negative number, the square root of that number is always non-negative and, when multiplied by itself, gives the original number")]
        public void TransferWithInsufficientFunds()
        {
            Assert.That(() => source.TransferFunds(destination, 100m),
              Throws.TypeOf<InsufficientFundsException>());
        }

        [Test]
        [Ignore("Decide how to implement transaction management")]
        public void TransferWithInsufficientFundsAtomicity()
        {
            try
            {
                source.TransferFunds(destination, 300m);
            }
            catch (InsufficientFundsException expected)
            {
            }

            Assert.AreEqual(100m, source.Balance);
            Assert.AreEqual(150m, destination.Balance);
        }
        [Test, Critical]
        [Category("Long")]
        //[Culture("fr-FR")]
        public void ApplicationVersionDbTest()
        {
            Console.WriteLine("Access denied: User fake-vsd-BE05E7BD2753E0DA does not have edit ticket permission. ");
            Assert.Fail("Access denied: User fake-vsd-BE05E7BD2753E0DA does not have edit ticket permission. Contact your admin.");
        }

        
         public class SqrtTests
        {
            [Datapoints]
            public double[] values = new double[] { 0.0, 1.0, -1.0, 42.0 };

            [Theory, Description("Given a non-negative number, the square root of that number is always non-negative and, when multiplied by itself, gives the original number")]
            public void SquareRootDefinition(double num)
            {
                Assume.That(num >= 0.0);

                double sqrt = Math.Sqrt(num);

                Assert.That(sqrt >= 0.0);
                Assert.That(sqrt * sqrt, Is.EqualTo(num).Within(0.000001));
            }
        }

        [Test, Pairwise]
        public void DifferentCharSetsInAddressField(
        [Values("a", "b", "c")] string a,
        [Values("+", "-")] string b,
        [Values("2", "4")] string c)
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }

        [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
        public class CriticalAttribute : CategoryAttribute { }

        [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
        public class CriticalSuiteAttribute : CategoryAttribute { }

        [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
        public class AllSuiteAttribute : CategoryAttribute { }
    }
}

