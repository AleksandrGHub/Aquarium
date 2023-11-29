using System;

namespace Aquarium
{
    class Catalog
    {
        private Fish[] _fishs = new Fish[7];

        public Catalog()
        {
            _fishs[0] = new Fish("Комета", 35);
            _fishs[1] = new Fish("Вуалехвост", 40);
            _fishs[2] = new Fish("Телескоп", 25);
            _fishs[3] = new Fish("Гуппи", 10);
            _fishs[4] = new Fish("Пецилия", 30);
            _fishs[5] = new Fish("Дискус", 20);
            _fishs[6] = new Fish("Хемихромис", 15);
        }

        public void Show()
        {
            int topPosition = 0;
            int leftPosition = 0;
            int offsetLeftPosition = 18;
            Console.Clear();

            for (int i = 0; i < _fishs.Length; i++)
            {
                topPosition++;
                Console.SetCursorPosition(leftPosition, topPosition);
                Console.Write($"[{i}] {_fishs[i].Name}");
                Console.SetCursorPosition(leftPosition + offsetLeftPosition, topPosition);
                Console.Write($"возраст {_fishs[i].Age}");
                Console.WriteLine();
            }
        }

        public Fish GetFish()
        {
            int minNumber = 0;
            int maxNumber = _fishs.Length;
            int index;

            do
            {
                Console.WriteLine("Введите индекс рыбки!");
                index = Utility.GetNumber();
            }
            while (index < minNumber || index >= maxNumber);

            return _fishs[index];
        }
    }
}