using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    public class DinnerParty : Party
    {
        public bool HelthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool helthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HelthyOption = helthyOption;
            FancyDecorations = fancyDecorations;
        }

        public decimal CalculateCostOfBeveregePerPerson()
        {
            decimal costOfBeveregePerPerson;
            if (HelthyOption)
            {
                costOfBeveregePerPerson = 5.00M;
            }
            else
            {
               costOfBeveregePerPerson = 20.00M;
            }
            return costOfBeveregePerPerson;
        }

        public override decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += CalculateCostOfBeveregePerPerson() * NumberOfPeople;
                if (HelthyOption)
                    return totalCost * 0.95M;
                return totalCost;
            }
        }
    }
}
