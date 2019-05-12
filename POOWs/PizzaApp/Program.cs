using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza("Salami", new PizzaBase("italian", 15));
            PizzaTopping tomatoes = new PizzaTopping("tomatoes", 2);
            PizzaTopping salami = new PizzaTopping("salami", 12);
            PizzaTopping mozz = new PizzaTopping("mozzarella", 6);

            pizza1.AddTopping(tomatoes);
            pizza1.AddTopping(salami);
            pizza1.AddTopping(mozz);
            pizza1.Print();

            Pizza pizza2 = new Pizza("Diavolo", new PizzaBase("regular", 9));
            pizza2.AddTopping(new PizzaTopping("salami", 11));
            pizza2.AddTopping(new PizzaTopping("mozzarella", 6));
            pizza2.AddTopping(new PizzaTopping("tomatoes", 3));
            pizza2.AddTopping(new PizzaTopping("pepper", 4));
            pizza2.Print();

            Pizza pizza3 = new Pizza("tonno", new PizzaBase("thick", 9));
            pizza3.AddTopping(new PizzaTopping("tuna", 11));
            pizza3.AddTopping(new PizzaTopping("mozzarella", 6));
            pizza3.AddTopping(new PizzaTopping("tomatoes", 3));
            pizza3.AddTopping(new PizzaTopping("gorgonzolla", 4));
            pizza3.Print();
        }
    }
}
