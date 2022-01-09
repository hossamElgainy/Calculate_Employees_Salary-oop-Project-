namespace OOPProject
{
    public class Employee
    {
        public const int MinimumLoggedHours = 176;
        public const decimal OverTimeRate = 1.25m;
        public int Id { get; set; }
        public string Name { get; set; }
        public int LoggedHours { get; set; }
        public decimal Wage { get; set; }
        private decimal CalculateBaseSalary()
        {
            return Wage * MinimumLoggedHours;
        }
        private decimal CalculateOverTime()
        {
            var AdditionalHours = LoggedHours - MinimumLoggedHours;
            return AdditionalHours * Wage * OverTimeRate;
        }
        protected virtual decimal Calculate()
        {
            return CalculateBaseSalary() + CalculateOverTime();
        }
        public override string ToString()
        {
            var Type = GetType().ToString().Replace("OOPProject.", "");
            return $"{Type}"+
                    $"\nId: {Id}"+
                    $"\nName: {Name}"+
                    $"\nLoggedHours: {LoggedHours} hrs/Month"+
                    $"\nWage: {Wage} $/hrs"+
                    $"\nBase Salary: {CalculateBaseSalary()} $/Month" +
                    $"\nOver Time: {CalculateOverTime()} $/Month";
        }
    }
}
