using System;

namespace OOPProject
{
    public class Programmers : Employee
    {
        public const decimal Commision = 0.03m;
        public bool TaskCompleted { get; set; }
        public decimal CalculateBonus()
        {
            if (TaskCompleted)
                return base.Calculate() * Commision;
            return 0;
        }
        protected override decimal Calculate() // Total Salary
        {
            return base.Calculate() + CalculateBonus();
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nTask Completed: {(TaskCompleted? "Yas": "No")} " +
                $"\nBonus: {Math.Round(CalculateBonus(), 2):N0} $" +
                 $"\nNet Salary: {Math.Round(this.Calculate(), 2):N0} $/Month";
        }
    }


}
