namespace PizzaApp
{
    class PizzaTopping
    {
        private enum Cheese { mozzarella, cheddar, gorgonzolla };
        private enum Meat { salami, ham, sausages, tuna, seafood };
        private enum Vegetable { tomatoes, cucumbers, mushrooms, onion, garlic, pepper, corn, punpkins };
        private string name;
        private double cost;

        internal string Name
        {
            get
            {
                if(System.Enum.IsDefined(typeof(Meat), this.name.ToLower()))
                {
                    return name.ToUpper();
                }
                else
                {
                    return name;
                }  
            }
            set
            {
                if(System.Enum.IsDefined(typeof(Cheese), value.ToLower()) || System.Enum.IsDefined(typeof(Meat), value.ToLower()) || System.Enum.IsDefined(typeof(Vegetable), value.ToLower()))
                {
                    name = value;
                }
                else
                {
                    System.Console.WriteLine("There is a topping I don't have tried yet");
                }
            }
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
            System.Console.Write($"{Name} (${Cost})");
        }
    }
}
