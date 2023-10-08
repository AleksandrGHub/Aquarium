using System;
using System.Collections.Generic;

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
        private Aquarium _aquarium = new Aquarium();

        public void Perform()
        {
            string userInput;

            do
            {
                Console.Clear();
                ShowMenu();
                Console.WriteLine("\n******************************************\n");
                _aquarium.ShowInfo();
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        if (_aquarium.IsEmpty())
                        {
                            Console.WriteLine("Чтобы достать рыбу нажмите соответствующую цифру.");
                            _aquarium.DeleteFish(Convert.ToInt32(Console.ReadLine()));
                            _aquarium.PerformIteration();
                        }
                        else
                        {
                            Console.WriteLine("Аквариум пустой!");
                            Console.ReadKey();
                        }
                        break;
                    case "2":
                        if (_aquarium.IsFull())
                        {
                            Console.Clear();
                            ShowFishes();
                            Console.WriteLine("\nДля добавления рыбы нажмите соответствующую цифру.");
                            _aquarium.PerformIteration();
                            _aquarium.AddFish(GetFish(Console.ReadLine()));
                        }
                        else
                        {
                            Console.WriteLine("Аквариум полный!");
                            Console.ReadKey();
                        }
                        break;
                    case "3":
                        _aquarium.PerformIteration();
                        break;
                }

            } while ("4" == userInput == false);
        }

        private void ShowMenu()
        {
            Console.WriteLine("Нажмите цифру соответствующую пункту меню.\n");
            Console.WriteLine("1 Достать рыбу из аквариума\n2 Добавить рыбу в аквариум\n3 Следующая итерация\n4 Выход");
        }

        private void ShowFishes()
        {
            Console.WriteLine("1 Комета, возраст 35\n2 Вуалехвост, возраст 40\n3 Телескоп, возраст 25\n4 Гуппи, возраст 10\n5 Пецилия, возраст 30\n6 Дискус, возраст 20\n7 Хемихромис, возраст 15");
        }

        private Fish GetFish(string number)
        {
            Fish fish = null;

            switch (number)
            {
                case "1":
                    fish = new Fish("Комета", 35);
                    break;
                case "2":
                    fish = new Fish("Вуалехвост", 40);
                    break;
                case "3":
                    fish = new Fish("Телескоп", 25);
                    break;
                case "4":
                    fish = new Fish("Гуппи", 10);
                    break;
                case "5":
                    fish = new Fish("Пецилия", 30);
                    break;
                case "6":
                    fish = new Fish("Дискус", 20);
                    break;
                case "7":
                    fish = new Fish("Хемихромис", 15);
                    break;
                default:
                    Console.WriteLine("введите цифру от 1 до 7");
                    Console.ReadKey();
                    break;
            }

            return fish;
        }
    }

    class Aquarium
    {
        private int _maxNumberFish = 5;
        private List<Fish> _fishs = new List<Fish>();

        public void AddFish(Fish fish)
        {
            if (fish != null)
            {
                _fishs.Add(fish);
            }
        }

        public void ShowInfo()
        {
            int constanta = 1;
            Console.WriteLine($"В аквариуме {_fishs.Count} рыб.");

            for (int i = 0; i < _fishs.Count; i++)
            {
                Console.Write($"{i + constanta} ");
                _fishs[i].ShowInfo();
            }
        }

        public void DeleteFish(int number)
        {
            int constanta = 1;

            if (number - constanta >= 0 & number - constanta < _fishs.Count)
            {
                _fishs.RemoveAt(number - constanta);
            }
            else
            {
                Console.WriteLine("Введите порядковый номер рыбки!");
                Console.ReadKey();
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

        public bool IsFull()
        {
            return _fishs.Count != _maxNumberFish;
        }

        public bool IsEmpty()
        {
            return _fishs.Count != 0;
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
            string text = null;

            if (IsDead())
            {
                text = " , рыбка умерла :(";
            }

            Console.WriteLine($"{Name}, возраст: {Age}{text}");
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