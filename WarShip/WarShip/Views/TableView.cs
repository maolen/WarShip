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
            bool isDigit = true;
            for (int i = 0; i <= 10; i++)
            {
                List<int> colShip = new List<int>();
                bool isRowHaveShip = false;
                foreach (var item in position)
                {
                    if (item.Alph == i)
                    {
                        isRowHaveShip = true;
                        colShip.Add(item.Number);
                    }
                }

                for (int j = 0; j < 11; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            Console.Write("\t");
                        }
                        if (j < 10)
                            Console.Write($"  {symv}");
                            symv++;
                    }
                    else
                    {
                        if (isDigit)
                        {
                            Console.Write($"{i}\t");
                            isDigit = false;
                        }
                        else
                        {
                            if (isRowHaveShip)
                            {
                                bool isShip = false;
                                foreach (var item in colShip)
                                {
                                    if (item == j)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("  █");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else
                                    {
                                        Console.Write("  █");
                                    }
                                }
                            }
                            else
                            {
                                Console.Write("  █");
                            }

                        }
                    }
                }
                isDigit = true;
                Console.WriteLine("\n");
            }
        }

        public void ShowWithCursorParametr(List<PositionShip> position, int col, int row)
        {
            char symv = 'A';
            bool isDigit = true;
            int rowTemp = row + 1;
            for (int i = 0; i <= 10; i++)
            {
                Console.SetCursorPosition(col, rowTemp + i);
                for (int j = 1; j <= 10; j++)
                {
                    if (i == 0)
                    {
                        if (j == 1)
                        {
                            Console.Write("\t");
                        }
                        Console.Write($"  {symv}");
                        symv++;
                    }
                    else
                    {
                        if (isDigit)
                        {
                            Console.Write($"{i}\t");
                            isDigit = false;
                        }
                        else
                        {
                            Console.Write("  █");
                        }
                    }
                }
                rowTemp++;
                if (i != 0)
                {
                    Console.Write("  █");
                }
                isDigit = true;
                Console.WriteLine("\n");
            }
        }
    }
}
