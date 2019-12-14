using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartyPlanner;

namespace PartyPlannerTests
{
    [TestClass]
    public class DinnerPartyTests
    {
        [TestMethod]
        public void DinnerPartyTest()
        {
            //arrange
            int numberOfPeople = 15;
            bool helthyOption = true;
            bool fancyDecoration = true;

            //act
            DinnerParty party = new DinnerParty(numberOfPeople, helthyOption, fancyDecoration);

            //assert
            Assert.AreEqual(party.NumberOfPeople, numberOfPeople);
            Assert.AreEqual(party.HelthyOption, helthyOption);
            Assert.AreEqual(party.FancyDecorations, fancyDecoration);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Imposable numberOfPeople")]
        public void NegativeDinnerPartyTest()
        {
            //arrange
            int numberOfPeople = -1;
            bool helthyOption = true;
            bool fancyDecoration = true;

            //act
            DinnerParty party = new DinnerParty(numberOfPeople, helthyOption, fancyDecoration);

            //assert
            Assert.AreEqual(party.NumberOfPeople, numberOfPeople);
        }

        [TestMethod]
        public void CalculateCostOfBeveregePerPersonTest()
        {
            //arrange
            int numberOfPeople = 15;
            bool helthyOption1 = true;
            bool helthyOption2 = false;
            bool fancyDecoration = true;
            decimal expected1 = 5M;
            decimal expected2 = 20M;

            //act
            DinnerParty party1 = new DinnerParty(numberOfPeople, helthyOption1, fancyDecoration);
            decimal actual1 = party1.CalculateCostOfBeveregePerPerson();

            DinnerParty party2 = new DinnerParty(numberOfPeople, helthyOption2, fancyDecoration);
            decimal actual2 = party2.CalculateCostOfBeveregePerPerson();

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeCalculateCostOfBeveregePerPersonTest()
        {
            //arrange
            int numberOfPeople = 0;
            bool helthyOption = true;
            bool fancyDecoration = true;

            //act
            DinnerParty party = new DinnerParty(numberOfPeople, helthyOption, fancyDecoration);
            party.CalculateCostOfBeveregePerPerson();

            //assert
        }

        [TestMethod]
        public void CostTest()
        {
            //arrange
            int numberOfPeople = 3;
            bool fancyDecoration = true;
            bool helthyOption1 = true;
            bool helthyOption2 = false;
            decimal expected1 = 175.75M;
            decimal expected2 = 230M;

            //act
            DinnerParty party1 = new DinnerParty(numberOfPeople, helthyOption1, fancyDecoration);
            party1.CalculateCostOfBeveregePerPerson();
            decimal actual1 = party1.Cost;

            DinnerParty party2 = new DinnerParty(numberOfPeople, helthyOption2, fancyDecoration);
            party1.CalculateCostOfBeveregePerPerson();
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
            int numberOfPeople = 32;
            bool fancyDecoration = true;
            bool helthyOption = true;

            //act
            DinnerParty party = new DinnerParty(numberOfPeople, helthyOption, fancyDecoration);
            party.CalculateCostOfBeveregePerPerson();
            decimal actual = party.Cost;

            //assert
        }
    }
}
