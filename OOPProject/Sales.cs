using System;

namespace OOPProject
{
    public class Sales : Employee
    {
        public decimal SalesVolume {get;set;}
        public decimal Commision {get;set;}

        public decimal CalculateBonus()
        {
            return SalesVolume * Commision;
        }
        protected override decimal Calculate() // Total Salary
        {
            return base.Calculate() + CalculateBonus();
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nCommision: {Math.Round(Commision, 2):N0} $" +
                $"\nBonus: {Math.Round(CalculateBonus(), 2):N0} $" +
                 $"\nNet Salary: {Math.Round(this.Calculate(), 2):N0} $/Month";
        }
    }


}
