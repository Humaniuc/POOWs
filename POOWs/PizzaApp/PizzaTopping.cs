namespace PizzaApp
{
    class PizzaTopping
    {
        private string name;
        private double cost;

        internal string Name
        {
            get { return name; }
            set { name = value; }
        }

        internal double Cost
        {
            get { return cost; }
            set
            {
                if(value > 0)
                {
                    cost = value;
                }
                else
                {
                    System.Console.WriteLine("Cost cannot be negative");
                }
            }
        }
        internal PizzaTopping(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
        internal void Print()
        {
            System.Console.WriteLine($"{name} (${cost})");
        }
    }
}
