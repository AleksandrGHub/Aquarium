using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class Menu
    {
        const string AddCommand = "add";
        const string DeleteCommand = "del";
        const string ExitCommand = "exit";
        const string ReduceLife = "reduce";
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