using System;

namespace OOPProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Managers m = new Managers
            {
                Id = 1000,
                Name = "hossam",
                LoggedHours = 180,
                Wage = 10,
            };

            Maintenance main = new Maintenance
            {
                Id = 1100,
                Name = "Kalid",
                LoggedHours = 186,
                Wage = 11,
            };

            Sales Sa = new Sales
            {
                Id = 1001,
                Name = "Mohamed",
                LoggedHours = 200,
                Wage = 12,
                SalesVolume = 120,
                Commision=0.05m
            };
            Programmers Pro = new Programmers
            {
                Id = 1002,
                Name = "Eman",
                LoggedHours = 182,
                Wage = 13,
                TaskCompleted=true,
            };
            Employee[] emp = { m, main, Sa, Pro };
            foreach(var E in emp)
            {
                Console.WriteLine("\n-------------------");
                Console.WriteLine(E);
            }
            Console.WriteLine(m);
        }
    }
}
