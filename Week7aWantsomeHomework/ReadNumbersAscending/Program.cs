using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNumbersAscending
{
    partial class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> nums = new List<int>();
                nums.Add(ReadNumber(1, 100));
                for (int i = 1; i < 3; i++)
                {
                    nums.Add(ReadNumber(nums.Last(), 100));
                }
                PrintNumbers(nums);
            }
            catch(InvalidNumberException)
            {
                Console.WriteLine("Number isn't between range.");
            }
            catch(NonNumberException)
            {
                Console.WriteLine("There was writed not numbers to console");
            }
            catch(System.IO.IOException e)
            {
                Console.WriteLine($"IO exception {e.InnerException}");
            }
        }

        static int ReadNumber(int start, int end)
        {
            int num;
            while(true)
            {
                Console.WriteLine($"Write a number greather than {start} and smaller than {end}");
                if(int.TryParse(Console.ReadLine(), out num))
                {
                    if(num < start || num > end)
                    {
                        throw new InvalidNumberException();
                    }
                    else
                    {
                        return num;
                    }
                }
                else
                {
                    throw new NonNumberException();
                }
            }
        }

        static void PrintNumbers(List<int> nums)
        {
            foreach (int num in nums)
            {
                if(num < nums.ElementAt(nums.Count - 1))
                {
                    Console.Write($"{num} < ");
                }
                else
                {
                    Console.Write($"{num} < 100");
                }
            }
            Console.WriteLine();
        }
    }
}
