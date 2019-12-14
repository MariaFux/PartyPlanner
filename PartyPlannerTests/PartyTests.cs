using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartyPlanner;

namespace PartyPlannerTests
{
    [TestClass]
    public class PartyTests
    {
        [TestMethod]
        public void CalculateCostOfDecorationsTest()
        {
            //arrange
            decimal expected1 = 95M;
            decimal expected2 = 52.50M;
            
            //act
            Party party1 = new Party();
            party1.FancyDecorations = true;
            party1.NumberOfPeople = 3;
            decimal actual1 = party1.CalculateCostOfDecorations();

            Party party2 = new Party();
            party2.FancyDecorations = false;
            party2.NumberOfPeople = 3;
            decimal actual2 = party2.CalculateCostOfDecorations();

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeCalculateCostOfDecorationsTest()
        {
            //arrange

            //act
            Party party = new Party();
            party.FancyDecorations = true;
            party.NumberOfPeople = -2;
            party.CalculateCostOfDecorations();

            //assert
        }

        [TestMethod]
        public void CostTests()
        {
            //arrange
            decimal expected1 = 170M;
            decimal expected2 = 127.50M;
            decimal expected3 = 750M;

            //act
            Party party1 = new Party();
            party1.FancyDecorations = true;
            party1.NumberOfPeople = 3;
            decimal actual1 = party1.Cost;

            Party party2 = new Party();
            party2.FancyDecorations = false;
            party2.NumberOfPeople = 3;
            decimal actual2 = party2.Cost;

            Party party3 = new Party();
            party3.FancyDecorations = true;
            party3.NumberOfPeople = 15;
            decimal actual3 = party3.Cost;

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeCostTests()
        {
            //arrange

            //act
            Party party = new Party();
            party.FancyDecorations = true;
            party.NumberOfPeople = 34;
            decimal acttual = party.Cost;

            //assert
        }
    }
}
