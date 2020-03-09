using System;
using System.Collections.Generic;
using System.Text;
using WarShip.Interfaces;

namespace WarShip.Views
{
    public class MenuView : IMenuView
    {
        public List<string> Puncts { get; private set; }
        public MenuView()
        {
            Puncts = new List<string>();
            Puncts.Add("Играть");
            Puncts.Add("Рекорды");
            Puncts.Add("Выход");
        }
        public void Show()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n");
            foreach (var item in Puncts)
            {
                Console.WriteLine($"\t\t\t\t\t\t{item}");
            }
        }

        public void Show(int punct)
        {
            int counter = 0;
            Console.WriteLine("\n\n\n\n\n\n\n\n");
            foreach (var item in Puncts)
            {
                if (counter == punct) 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\t\t\t\t\t\t> {item} <");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine($"\t\t\t\t\t\t{item}");
                }
                counter++;
            }
        }
    }
}
