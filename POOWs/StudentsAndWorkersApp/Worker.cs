namespace StudentsAndWorkersApp
{
    class Worker : Human
    {
        private double moneyPerHour;
        private int workHoursPerDay;

        internal double MoneyPerHour
        {
            get { return moneyPerHour; }
            set
            {
                if(double.TryParse(value.ToString(), out moneyPerHour))
                {
                    return;
                }
                else
                {
                    System.Console.WriteLine("Value cannot be parsed");
                }
            }
        }

        internal int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {
                if(value < 2)
                {
                    System.Console.WriteLine("There must be at least 2 working hours per day");
                }
                else if(value > 10)
                {
                    System.Console.WriteLine("Work hours per day must be least than 10");
                }
                else
                {
                    workHoursPerDay = value;
                }
            }
        }

        internal Worker(string firstName, string secondName, double moneyPerHour, int workHoursPerDay) : base(firstName, secondName)
        {
            MoneyPerHour = moneyPerHour;
            WorkHoursPerDay = workHoursPerDay;
        }

        internal double WeekSalary()
        {
            return MoneyPerHour * WorkHoursPerDay;
        }

        internal void Print()
        {
            System.Console.WriteLine($"{FirstName} {LastName} has {WeekSalary()} dollars per week");
        }
    }
}
