using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharppi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Hero hero = new Hero("mörkö", 12, 155.0f, 120.0);

            hero.Print();
            hero.SetAge(84);

            Console.WriteLine(hero.GetName() + " on nyt " + hero.GetAge() + "-vuotias");
        }
    }
}
