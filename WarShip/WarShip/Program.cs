using System;
using WarShip.Function;
using WarShip.Views;
using WarShip.DBContext;
using WarShip.DTOs;

namespace WarShip
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithMenu work = new WorkWithMenu();
            work.Menu.Show(0);
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.DownArrow)
                {
                    work.DownPunctMenu();
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    work.UpPunctMenu();
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (work.Menu.Puncts[work._currentPunct] == "Выход")
                    {
                        break;
                    }
                    else
                    {
                        work.EnterPunctMenu();
                    }   
                }
            }
        }
    }
}
