using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    public class Party
    {
        int numberOfPeople;
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { 
            get 
            {
                return numberOfPeople; 
            } 
            set 
            { 
                if (value <= 0 || value > 30) 
                {
                    //numberOfPeople = 1; 
                    throw new ArgumentException("Invalid numberOfPeople");
                } 
                else 
                    numberOfPeople = value; 
            } 
        }
        public bool FancyDecorations { get; set; }        

        public decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            return costOfDecorations;
        }

        public virtual decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople; 
                if (NumberOfPeople > 12)
                    totalCost += 100M;
                return totalCost;
            }
        }
    }
}
