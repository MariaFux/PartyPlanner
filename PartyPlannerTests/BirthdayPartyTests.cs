using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartyPlanner;

namespace PartyPlannerTests
{
    [TestClass]
    public class BirthdayPartyTests
    {
        [TestMethod]
        public void BirthdayPartyTest()
        {
            //arrange
            int numberOfPeople = 15;
            bool fancyDecoration = true;
            string cakeWriting = "Happy";

            //act
            BirthdayParty party = new BirthdayParty(numberOfPeople, fancyDecoration, cakeWriting);

            //assert
            Assert.AreEqual(party.NumberOfPeople, numberOfPeople);
            Assert.AreEqual(party.FancyDecorations, fancyDecoration);
            Assert.AreEqual(party.CakeWriting, cakeWriting);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Imposable numberOfPeople")]
        public void NegativeBirthdayPartyTest() 
        {
            //arrange
            int numberOfPeople = 40;
            bool fancyDecoration = true;
            string cakeWriting = "Happy";            

            //act
            BirthdayParty party = new BirthdayParty(numberOfPeople, fancyDecoration, cakeWriting);            

            //assert
            Assert.AreEqual(party.NumberOfPeople, numberOfPeople);
        }

        [TestMethod]
        public void CakeSizeTest()
        {
            //arrange
            int numberOfPeople1 = 15;
            int numberOfPeople2 = 3;
            bool fancyDecoration = true;
            string cakeWriting = "Happy";
            int expected1 = 16;
            int expected2 = 8;

            //act
            BirthdayParty party1 = new BirthdayParty(numberOfPeople1, fancyDecoration, cakeWriting);
            int actual1 = party1.CakeSize();

            BirthdayParty party2 = new BirthdayParty(numberOfPeople2, fancyDecoration, cakeWriting);
            int actual2 = party2.CakeSize();

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeCakeSizeTest()
        {
            //arrange
            int numberOfPeople = -1;
            bool fancyDecoration = true;
            string cakeWriting = "Happy";

            //act
            BirthdayParty party = new BirthdayParty(numberOfPeople, fancyDecoration, cakeWriting);
            party.CakeSize();

            //assert
        }

        [TestMethod]
        public void MaxWritingLengthTest()
        {
            //arrange
            int numberOfPeople1 = 15;
            int numberOfPeople2 = 3;
            bool fancyDecoration = true;
            string cakeWriting = "Happy";
            int expected1 = 40;
            int expected2 = 16;

            //act
            BirthdayParty party1 = new BirthdayParty(numberOfPeople1, fancyDecoration, cakeWriting);
            party1.CakeSize();
            int actual1 = party1.MaxWritingLength();

            BirthdayParty party2 = new BirthdayParty(numberOfPeople2, fancyDecoration, cakeWriting);
            party2.CakeSize();
            int actual2 = party2.MaxWritingLength();

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeMaxWritingLengthTest()
        {
            //arrange
            int numberOfPeople = 0;
            bool fancyDecoration = true;
            string cakeWriting = "Happy";

            //act
            BirthdayParty party = new BirthdayParty(numberOfPeople, fancyDecoration, cakeWriting);
            party.CakeSize();
            party.MaxWritingLength();

            //assert
        }

        [TestMethod]
        public void CakeWritingTooLongTest()
        {
            //arrange
            int numberOfPeople = 3;
            bool fancyDecoration = true;
            string cakeWriting1 = "Happy Birthday";
            string cakeWriting2 = "Happy Birthday my dear grendma!";
            bool expected1 = false;
            bool expected2 = true;

            //act
            BirthdayParty party1 = new BirthdayParty(numberOfPeople, fancyDecoration, cakeWriting1);
            party1.CakeSize();
            party1.MaxWritingLength();
            bool actual1 = party1.CakeWritingTooLong;

            BirthdayParty party2 = new BirthdayParty(numberOfPeople, fancyDecoration, cakeWriting2);
            party2.CakeSize();
            party2.MaxWritingLength();
            bool actual2 = party2.CakeWritingTooLong;

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeCakeWritingTooLongTest()
        {
            //arrange
            int numberOfPeople = 35;
            bool fancyDecoration = true;
            string cakeWriting = "Happy Birthday";

            //act
            BirthdayParty party = new BirthdayParty(numberOfPeople, fancyDecoration, cakeWriting);
            party.CakeSize();
            party.MaxWritingLength();
            bool actual1 = party.CakeWritingTooLong;

            //assert
        }

        [TestMethod]
        public void ActualLengthTest()
        {
            //arrange
            int numberOfPeople = 3;
            bool fancyDecoration = true;
            string cakeWriting1 = "Happy Birthday";
            string cakeWriting2 = "Happy Birthday my dear grendma!";
            int expected1 = 14;
            int expected2 = 16;

            //act
            BirthdayParty party1 = new BirthdayParty(numberOfPeople, fancyDecoration, cakeWriting1);
            party1.CakeSize();
            party1.MaxWritingLength();
            int actual1 = party1.ActualLength;

            BirthdayParty party2 = new BirthdayParty(numberOfPeople, fancyDecoration, cakeWriting2);
            party2.CakeSize();
            party2.MaxWritingLength();
            int actual2 = party2.ActualLength;

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeActualLengthTest()
        {
            //arrange
            int numberOfPeople = -5;
            bool fancyDecoration = true;
            string cakeWriting = "Happy Birthday";

            //act
            BirthdayParty party = new BirthdayParty(numberOfPeople, fancyDecoration, cakeWriting);
            party.CakeSize();
            party.MaxWritingLength();
            int actual = party.ActualLength;

            //assert
        }

        [TestMethod]
        public void CostTest()
        {
            //arrange
            int numberOfPeople1 = 3;
            int numberOfPeople2 = 5;
            bool fancyDecoration = true;
            string cakeWriting = "Happy";
            decimal expected1 = 211.25M;
            decimal expected2 = 326.25M;

            //act
            BirthdayParty party1 = new BirthdayParty(numberOfPeople1, fancyDecoration, cakeWriting);
            party1.CakeSize();
            party1.MaxWritingLength();
            decimal actual1 = party1.Cost;

            BirthdayParty party2 = new BirthdayParty(numberOfPeople2, fancyDecoration, cakeWriting);
            party2.CakeSize();
            party2.MaxWritingLength();
            decimal actual2 = party2.Cost;

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeCostTest()
        {
            //arrange
            int numberOfPeople = 31;
            bool fancyDecoration = true;
            string cakeWriting = "Happy";

            //act
            BirthdayParty party = new BirthdayParty(numberOfPeople, fancyDecoration, cakeWriting);
            party.CakeSize();
            party.MaxWritingLength();
            decimal actual = party.Cost;

            //assert
        }
    }
}
