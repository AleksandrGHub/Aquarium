using System;

namespace Aquarium
{
    class Menu
    {
        private const string AddCommand = "add";
        private const string DeleteCommand = "del";
        private const string ExitCommand = "exit";
        private const string ReduceLife = "reduce";

        private Aquarium _aquarium = new Aquarium();

        public void Show()
        {
            Console.WriteLine("**************Меню**************");
            Console.WriteLine($"Добавить рыбку   (команда: {AddCommand})");
            Console.WriteLine($"Удалить рыбку    (команда: {DeleteCommand})");
            Console.WriteLine($"Уменьшить жизнь  (команда: {ReduceLife})");
            Console.WriteLine($"Выйти            (команда: {ExitCommand})");
        }

        public void Work()
        {
            string userInput;

            do
            {
                Console.Clear();
                Show();
                _aquarium.ShowInfo();

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case AddCommand:
                        _aquarium.AddFish();
                        break;

                    case DeleteCommand:
                        _aquarium.DeleteFish();
                        break;

                    case ReduceLife:
                        _aquarium.ReduceLife();
                        break;
                }
            } while (userInput != ExitCommand);
        }
    }
}