using System;

namespace Aquarium
{
    class Menu
    {
        private const string AddCommand = "add";
        private const string DeleteCommand = "del";
        private const string ExitCommand = "exit";
        private const string ReduceLife = "reduce";
        private string _userInput;
        private Aquarium _aquarium = new Aquarium();

        public void ShowMenu()
        {
            Console.WriteLine("**************Меню**************");
            Console.WriteLine("Добавить рыбку   (команда: add)");
            Console.WriteLine("Удалить рыбку    (команда: del)");
            Console.WriteLine("Уменьшить жизнь  (команда: reduce)");
            Console.WriteLine("Выйти            (команда: exit)");
        }

        public void Work()
        {
            do
            {
                Console.Clear();
                ShowMenu();
                _aquarium.ShowInfo();
                _userInput = Console.ReadLine();

                switch (_userInput)
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
            } while (_userInput != ExitCommand);
        }
    }
}