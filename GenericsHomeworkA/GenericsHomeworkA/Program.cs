using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;

namespace GenericsHomeworkA
{
    class Program
    {
        static void Main(string[] args)
        {
            uint size = Reader.ReadNatural("Write array size: ");
            int[] arr = new int[size];
            GenericList<int> ls = new GenericList<int>(arr);
            Console.WriteLine("List empty: ");
            Console.WriteLine(ls.ToString());

            Console.WriteLine("Adding node: ");
            ls.Add(5);
            ls.Add(11);
            ls.Add(18);
            ls.Add(23);
            ls.Add(6);
            ls.Add(7);
            ls.Add(3);
            ls.Add(12);
            ls.Add(8);
            Console.WriteLine(ls.ToString());

            Console.WriteLine("After removing nodes");
            ls.RemoveByValue(3);
            ls.RemoveByValue(18);
            Console.WriteLine(ls.ToString());

            uint index;

            try
            {
                index = Reader.ReadNatural("Write index to search:");
                Console.WriteLine($"Element at index {index} is: {ls.ElementAt(index)}");

                index = Reader.ReadNatural("Write index to remove:");
                Console.WriteLine($"After removing at index {index}: ");
                ls.RemoveAt(index);
                Console.WriteLine(ls.ToString());
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NotFiniteNumberException e)
            {
                Console.WriteLine(e.Message);
            }
            

            try
            {
                index = Reader.ReadNatural("Write index to insert:");
                Console.WriteLine($"After inserting at index {index} value 19: ");
                ls.InsertAt(index, 19);
                Console.WriteLine(ls.ToString());
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Search by value 19: ");
            Console.WriteLine(ls.ElementAtByValue(19) > 0? $"Searched value is at {ls.ElementAtByValue(19)}" : "There is no such value");

            Console.WriteLine("After clear list:");
            ls.ClearList();
            Console.WriteLine(ls.ToString());
        }
        
    }
}
