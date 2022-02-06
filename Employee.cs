namespace NewCSharpConcepts
{
    public class Employee
    {
        public string Name { get; set; }
        protected double VacationDays;

        public virtual void TakeVacation() {}

        public Employee(string thisname)
        {
            Name = thisname;
        }

        public override string ToString()
        {
            return $"[Employee: Name = {Name}]";
        }
    }
}