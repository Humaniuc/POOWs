using System;
using System.Collections.Generic;

namespace HotelManagerApp
{
    public class Rate
    {
        readonly List<string> currency = new List<string>() { "RON", "EURO", "DOLLAR" };
        internal double Amount
        {
            get
            {
                return Amount;
            }
            set
            {
                if (value > 0)
                {
                    this.Amount = value;
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
                return Currency;
            }
            set
            {
                if(currency.Contains(value.ToUpper()))
                {
                    Currency = value.ToUpper();
                }
            }
        }

        internal Rate(double amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
        internal void Print()
        {
            Console.WriteLine($"Amount: {Amount}{Currency}");
        }
    }
}
