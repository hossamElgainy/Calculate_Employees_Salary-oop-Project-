using System;

namespace OOPProject
{
    public class Maintenance : Employee
    {
        private const decimal Hardship = 100m;
       
        protected override decimal Calculate() // Total Salary
        {
            return base.Calculate() + Hardship;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nHardship: {Math.Round(Hardship, 2):N0} $" +
                 $"\nNet Salary: {Math.Round(this.Calculate(), 2):N0} $/Month";
        }
    }


}
