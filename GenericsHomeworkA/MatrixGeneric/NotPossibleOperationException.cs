using System;

namespace MatrixGeneric
{
    public class NotPossibleOperationException : Exception
    {
        public NotPossibleOperationException(string s)
        {
            Console.WriteLine(s);
        }
    }

    
}
