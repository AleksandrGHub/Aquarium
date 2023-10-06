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
            Manager manager = new Manager();
            manager.Perform();
        }
    }

    class Manager
    {
        private Fish[] _fishs = new Fish[] { new Fish("Комета", 35), new Fish("Вуалехвост", 40), new Fish("Телескоп", 25), new Fish("Гуппи", 35), new Fish("Пецилия", 30), new Fish("Дискус", 20), new Fish("Хемихромис", 15) };
        private Aquarium _aquarium = new Aquarium();

        public void Perform()
        {
            string userInput;

            do
            {
                Console.Clear();
                ShowMenu();
                _aquarium.ShowInfo();
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Чтобы достать рыбу нажмите соответствующую цифру.");
                        _aquarium.DeleteFish(Convert.ToInt32(Console.ReadLine()));
                        _aquarium.PerformIteration();
                        break;
                    case "2":
                        ShowFishes();
                        Console.WriteLine("Для добавления рыбы нажмите соответствующую цифру.");
                        _aquarium.AddFish(GetFish(Convert.ToInt32(Console.ReadLine())));
                        _aquarium.PerformIteration();
                        break;
                    case "3":
                        _aquarium.PerformIteration();
                        break;
                }

            } while ("4" == userInput == false);
        }

        private void ShowMenu()
        {
            Console.WriteLine("Нажмите цифру соответствующую пункту меню.");
            Console.WriteLine("1 Достать рыбу из аквариума\n2 Добавить рыбу в аквариум\n3 Следующая итерация\n4 Выход");
        }

        private void ShowFishes()
        {
            for (int i = 0; i < _fishs.Length; i++)
            {
                Console.Write(i + " ");
                _fishs[i].ShowInfo();
            }
        }

        private Fish GetFish(int number)
        {
            Fish fish = null;

            if (number >= 0 & number < _fishs.Length)
            {
                fish = _fishs[number];
            }

            return fish;
        }
    }

    class Aquarium
    {
        private List<Fish> _fishs = new List<Fish>();

        public void AddFish(Fish fish)
        {
            _fishs.Add(fish);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"В аквариуме {_fishs.Count} рыб.");

            for (int i = 0; i < _fishs.Count; i++)
            {
                Console.Write($"{i} ");
                _fishs[i].ShowInfo();
            }
        }

        public void DeleteFish(int number)
        {
            if (number >= 0 & number < _fishs.Count)
            {
                _fishs.RemoveAt(number);
            }
            else
            {
                Console.WriteLine("Введите порядковый номер рыбки");
            }
        }

        public void PerformIteration()
        {
            foreach (Fish fish in _fishs)
            {
                if (fish.IsDead() == false)
                {
                    fish.ReduceLife();
                }
            }
        }
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

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Name}, возраст: {Age}");
        }

        public bool IsDead()
        {
            return Age <= 0;
        }

        public void ReduceLife()
        {
            Age -= 1;
        }
    }
}