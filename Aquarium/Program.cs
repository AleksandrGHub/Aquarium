using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Manager
    {

    }

    class Aquarium
    {
        private List<Fish> _fishs = new List<Fish>();
    }

    class Fish
    {
        public Fish(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
    }
}