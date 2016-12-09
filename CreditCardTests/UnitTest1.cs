using CsharpClearent;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CreditCardTests
{

    [TestClass]
    public class UnitTest1
    {
        public static double DELTA = .1;
        double visaRate = .10;
        double discoverRate = .01;
        double mastercardRate = .05;
        double balance = 100;

        [TestMethod]
        public void TestMethod1()
        {
            //1 person, 1 wallet. visa, mc, discover 100 balance each

           visa  visa1 = new visa("Visa", 100, visaRate);
            mastercard mc1 = new mastercard("Mastercard", 100, mastercardRate);
            discover discover1 = new discover("Discover", 100, discoverRate);

            double visaInterest = visa1.simpleInterest();
            double mcInterest = mc1.simpleInterest();
            double discInterest = discover1.simpleInterest();
            double totInterest = visaInterest + mcInterest + discInterest;

            Assert.AreEqual(10, visaInterest, DELTA); //visa interest
            Assert.AreEqual(5, mcInterest, DELTA); //mastercard interest
            Assert.AreEqual(1, discInterest, DELTA); //discover interest
            Assert.AreEqual(16, totInterest, DELTA); //total interest
        }
        [TestMethod]
        public void TestMethod2()
        {
            //1 person, 2 wallets. wallet1= visa, disc. wallet2= mc. 100 balance each

            visa visa1 = new visa("Visa", 100, visaRate);
            discover discover1 = new discover("Discover", 100, discoverRate);
            mastercard mc2 = new mastercard("Mastercard", 100, mastercardRate);

            double visaInterest = visa1.simpleInterest();
            double mcInterest = mc2.simpleInterest();
            double discInterest = discover1.simpleInterest();
            double totInterest = visaInterest + mcInterest + discInterest;

            Assert.AreEqual(16, totInterest, DELTA);//total interest
            Assert.AreEqual(11, visaInterest + discInterest, DELTA); //wallet 1 interest
            Assert.AreEqual(5, mcInterest, DELTA);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //2 people 1 wallet each.
            //person 1 has mc and visa. person 2 has visa and mc.  100 balance all cards,

            mastercard mc1 = new mastercard("Mastercard", 100, mastercardRate);
            visa visa1 = new visa("Visa", 100, visaRate);

            double mcInterest1 = mc1.simpleInterest();
            double visaInterest1 = visa1.simpleInterest();

            Assert.AreEqual(15, mcInterest1 + visaInterest1, DELTA);

            visa visa2 = new visa("Visa", 100, visaRate);
            mastercard mc2 = new mastercard("Mastercard", 100, mastercardRate);

            double mcInterest2 = mc2.simpleInterest();
            double visaInterest2 = visa2.simpleInterest();

            Assert.AreEqual(15, mcInterest2 + visaInterest2, DELTA);
        }

    }

}
