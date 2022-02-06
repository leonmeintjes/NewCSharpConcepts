using System;

namespace NewCSharpConcepts
{
    //class worker inherets from Employee (Worker is-a Employee)
    public class Worker : Employee
    {
        public double HourlyWage { get; set; }
        public Worker(string name, double wage)
            :base(name)
        {
            HourlyWage = wage;
        }
        public override void TakeVacation()
        {
            VacationDays += 10;
        }
        public override string ToString()
        {
            return $"[Worker. Name: {Name} Hourly wage {HourlyWage} Vacation {VacationDays}]";
        }
    }
    
}