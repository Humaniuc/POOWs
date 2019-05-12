using System.Collections.Generic;

namespace PizzaApp
{
    class Pizza
    {
        private enum PizzaName { quatrostagioni, salami, diavolo, prosciutto, tonno, vegetali };
        private string name;
        private PizzaBase pizzaBase;
        private List<PizzaTopping> toppings = new List<PizzaTopping>();

        internal string Name
        {
            get { return name; }
            set
            {
                if( System.Enum.IsDefined(typeof(PizzaName), value.ToLower()))
                {
                    name = value;
                }
                else
                {
                    System.Console.WriteLine("Have no such pizza");
                }
            }
        }
        internal PizzaBase PizzaB { get; set; }
        internal List<PizzaTopping> Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        internal Pizza(string name, PizzaBase pbase)
        {
            Name = name;
            PizzaB = pbase;
        }
        internal void AddTopping(PizzaTopping pt)
        {
            toppings.Add(pt);
        }

        internal double CalculateTotalCost()
        {
            double cost = PizzaB.Cost;
            foreach(PizzaTopping pt in Toppings)
            {
                cost += pt.Cost;
            }
            return cost;
        }
        internal void Print()
        {
            System.Console.WriteLine($"{Name}");
            PizzaB.Print();
            System.Console.WriteLine($"Toppings: ");
            foreach(PizzaTopping pt in toppings)
            {
                System.Console.Write("\t");
                pt.Print();
                System.Console.Write("\n");
            }
            System.Console.WriteLine($"Total Cost: ${CalculateTotalCost()}");
            System.Console.WriteLine();
        }
    }
}
