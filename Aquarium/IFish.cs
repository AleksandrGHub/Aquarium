using System;

namespace Aquarium
{
    interface IFish
    {
        IFish Clone();
        void ShowInfo();
        void ReduceLife();
    }

    class Fish : IFish
    {
        private int minAge = 0;

        public Fish(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }

        public IFish Clone()
        {
            return new Fish(Name, Age);
        }

        public void ShowInfo()
        {
            string text = null;

            if (Age <= minAge)
            {
                text = " , рыбка умерла :(";
            }

            Console.WriteLine($"{Name}, возраст: {Age}{text}");
        }

        public void ReduceLife()
        {
            if (Age > minAge)
            {
                Age--;
            }
        }
    }
}