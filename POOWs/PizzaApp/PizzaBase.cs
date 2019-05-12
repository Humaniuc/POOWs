﻿using System;

namespace PizzaApp
{
    class PizzaBase
    {
        private enum PizzaBaseName { regular, thick, italian };
        private string name;
        private double cost;

        internal string Name
        {
            get { return name; }
            set
            {
                if(Enum.IsDefined(typeof(PizzaBaseName), value.ToLower()))
                {
                    name = value.ToLower();
                }
                else
                {
                    Console.WriteLine("There is no such a pizza base name");
                }
            }
        }

        internal double Cost
        {
            get { return cost; }
            set
            {
                if(PizzaBaseName.italian == (PizzaBaseName)Enum.Parse(typeof(PizzaBaseName), this.name))
                {
                    cost = value * 1.5;
                }
                else
                {
                    cost = value;
                }
            }
        }

        internal PizzaBase(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        internal void Print()
        {
            Console.WriteLine($"Base: {name} (${cost})");
        }
    }
}
