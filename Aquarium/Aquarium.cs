using System;
using System.Collections.Generic;

namespace Aquarium
{
    class Aquarium
    {
        private Catalog _catalog = new Catalog();
        private List<Fish> _fishs = new List<Fish>();
        private int _maxNumberFishs = 5;

        public void AddFish()
        {
            Fish cloneFish;
            ShowCatalog();

            if (_fishs.Count < _maxNumberFishs)
            {
                cloneFish = _catalog.GetFish().Clone();

                _fishs.Add(cloneFish);
            }
            else
            {
                Console.WriteLine("В аквариуме максимальное количество рыбок!");
                Console.ReadKey();
            }

            Console.Clear();
        }

        public void DeleteFish()
        {
            int index;

            if (_fishs.Count == 0)
            {
                Console.WriteLine("В аквариуме нет рыбок!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Введите индекс удаляемой рыбки");

                do
                {
                    index = Utility.GetNumber();
                }
                while (index < 0 || index >= _fishs.Count);

                _fishs.RemoveAt(index);
            }
        }

        public void ReduceLife()
        {
            if (_fishs.Count > 0)
            {
                foreach (Fish fish in _fishs)
                {
                    fish.ReduceLife();
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"В аквариуме {_fishs.Count} рыб.");

            for (int i = 0; i < _fishs.Count; i++)
            {
                Console.Write($"[{i}] ");
                _fishs[i].ShowInfo();
            }
        }

        public void ShowCatalog()
        {
            _catalog.Show();
        }
    }
}