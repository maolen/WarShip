using System;
using System.Collections.Generic;
using System.Text;
using WarShip.Function;
using WarShip.Interfaces;

namespace WarShip.Views
{
    public class TableView : ITableView
    {
        public void Show(List<PositionShip> position)
        {
            char symv = 'A';
            Console.Write("\t");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{symv}  ");
                symv++;
            }

            Console.WriteLine("\n");
            for (int i = 1; i <= 10; i++)
            {
                List<int> shipOnRow = new List<int>();
                bool isRowHaveShip = false;
                foreach (var item in position)
                {
                    if (i == item.Alph)
                    {
                        shipOnRow.Add(item.Number);
                        isRowHaveShip = true;
                    }
                }
                Console.Write($"{i}\t");
                for (int j = 1; j <= 10; j++)
                {
                    if (isRowHaveShip)
                    {
                        foreach (var item in shipOnRow)
                        {
                            if (j == item)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("█  ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write("█  ");
                            }
                        }
                    }
                    else
                    {
                        Console.Write("█  ");
                    }
                }
                Console.WriteLine("\n");
            }
        }

        public void ShowWithCursorParametr(List<PositionShip> position, int col, int row)
        {
            char symv = 'A';
            Console.SetCursorPosition(col, row + 1);
            Console.Write("\t");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{symv}  ");
                symv++;
            }
            int rowTemp = row + 1;
            Console.WriteLine("\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.SetCursorPosition(col, rowTemp + 1 + i);
                Console.Write($"{i}\t");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("█  ");
                }
                Console.WriteLine("\n");
                rowTemp++;
            }
        }
    }
}
