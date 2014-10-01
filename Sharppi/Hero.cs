using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharppi
{
    class Hero
    {
        private string name;
        private int age;
        private float height;
        private double weight;

        public void Print()
        {
            Console.WriteLine(name + " on " + age.ToString() + "-vuotias");
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetName(string n)
        {
            name = n;
        }

        public void SetAge(int a)
        {
            age = a;
        }

        public Hero()
        {
            name = "default";
            age = 0;
            height = 0.0F;
            weight = 0.0D;
        }

        public Hero(string n, int a, float h, double w)
        {
            name = n;
            age = a;
            height = h;
            weight = w;
        }
    }
}
