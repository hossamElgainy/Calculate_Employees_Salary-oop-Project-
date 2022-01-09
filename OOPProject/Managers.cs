using System;

namespace OOPProject
{
    public class Managers : Employee
    {
        private const decimal AllowenceRate = 0.05m;
        private decimal CalculateAllowwnce()
        {
            return AllowenceRate * base.Calculate();
        }
        protected override decimal Calculate() // Total Salary
        {
            return base.Calculate() + CalculateAllowwnce();
        }
        public override string ToString()
        {
            return base.ToString()+
                $"\nAllowence: {Math.Round( CalculateAllowwnce(),2):N0} $" +
                 $"\nNet Salary: {Math.Round( this.Calculate(),2):N0} $/Month";
        }
    }

}
