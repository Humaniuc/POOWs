using System;
using System.Collections.Generic;

namespace SchoolApp
{
    class Teacher : IPeople
    {
        private string name;
        List<Discipline> disciplines;
        public string Name
        {
            get { return name; }
            set
            { 
                if(value != null)
                {
                    name = value;
                }
                else
                {
                    System.Console.WriteLine("Name cannot be null");
                }
            }
        } 

        List<Discipline> Disciplines { get; set; }
        public Teacher(string name, List<Discipline> disciplines)
        {
            Name = name;
            this.disciplines = disciplines;
        }
    }
}
