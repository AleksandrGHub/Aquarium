using System;

namespace Aquarium
{
    class Fish
    {
        private int _minLife = 0;

        public Fish(string name, int life)
        {
            Name = name;
            Life = life;
        }

        public string Name { get; private set; }
        public int Life { get; private set; }

        public Fish Clone()
        {
            return new Fish(Name, Life);
        }

        public void ShowInfo()
        {
            string text = null;

            if (Life <= _minLife)
            {
                text = " , рыбка умерла :(";
            }

            Console.WriteLine($"{Name}, возраст: {Life}{text}");
        }

        public void ReduceLife()
        {
            if (Life > _minLife)
            {
                Life--;
            }
        }
    }
}