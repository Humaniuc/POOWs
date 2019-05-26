﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student human = new Student("Juravle", "Humaniuc", "Petru", 1890223);
            human.address = "Straja, Suceava";
            human.Email = "human";
            human.Course = ".Net";
            human.University = Universities.Asachi.ToString();
            human.Faculty = Faculties.AutomaticaSiCalculatoare.ToString();
            human.Specialty = Specialties.CTI.ToString();
            System.Console.WriteLine(human.ToString());

            Student humaniuc = new Student("Humaniuc", "Juravle", "Petru", 1890223);
            System.Console.WriteLine(human.Equals(humaniuc)? "Equal objects" : "Unequal objects");
            System.Console.WriteLine($"{human.FirstName} has {human.GetHashCode()} hashcode");

            Student juravle = new Student("Humaniuc", "Juravle", "Petru", 888777);

            if(human == humaniuc)
            {
                System.Console.WriteLine($"{human.FirstName} is same student with {humaniuc.FirstName}");
            }

            if(human != juravle)
            {
                System.Console.WriteLine($"{human.FirstName} is different with {juravle.FirstName}");
            }

            System.Console.ReadLine();
        }
    }
}
