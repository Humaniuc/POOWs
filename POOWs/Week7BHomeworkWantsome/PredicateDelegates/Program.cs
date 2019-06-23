using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDelegates
{
    class Program
    {
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
        static void Main(string[] args)
        {
            // Predicate delegate
            Predicate<string> isUpper = IsUpperCase;
            string s = "hello world!!";
            bool result = isUpper(s);
            Console.WriteLine("{0} isUpper? : {1}", s, result);

            // Predicate delegate with anonymous method
            Predicate<string> isUpperAnonym = delegate (string str) { return str.Equals(str.ToUpper()); };
            Console.WriteLine("{0} isUpper? = {1}", s, isUpperAnonym(s));

            // Predicate delegate with lambda expression
            Predicate<string> isUpperLambda = sLam => sLam.Equals(sLam.ToUpper());
            Console.WriteLine("{0} isUpper? = {1}", s, isUpperLambda(s));

        }
    }
}
