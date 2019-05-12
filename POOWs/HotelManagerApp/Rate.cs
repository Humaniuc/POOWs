using System;
using System.Collections.Generic;

namespace HotelManagerApp
{
    class Rate
    {
        private double amount;
        private string currency;
        internal enum Currencies { RON, EURO, DOLLAR };
        internal double Amount 
        {
            get
            {
                return amount;
            }
            set
            {
                if (value > 0)
                {
                    amount = value;
                }
                else
                {
                    Console.WriteLine("The price cannot be negative.");
                }
            }
        }
        internal string Currency
        {
            get
            {
                return currency;
            }
            set
            {
                if(Enum.IsDefined(typeof(Currencies), value.ToUpper()))
                {
                    currency = value.ToUpper();
                }
                else
                {
                    Console.WriteLine("These currency is not implemented");
                }
            }
        }

        internal Rate(double amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }
        internal void Print()
        {
            Console.WriteLine($"Amount: {Amount} {Currency}");
        }
    }
}
