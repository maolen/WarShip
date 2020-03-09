using System;
using System.Collections.Generic;
using System.Text;
using WarShip.DTOs;
using WarShip.Interfaces;
using WarShip.Views;

namespace WarShip.Function
{
    public class Game : IGame
    {
        public TableView PlayerTable { get; set; }
        public List<PositionShip> PlayerShips { get; set; }
        public TableView ComputerTable { get; set; }
        public Player Player { get; set; }

        int boat = 4;
        int destroyers = 3;
        int cruisers = 2;
        int battleship = 1;
        public Game()
        {
            PlayerShips = new List<PositionShip>();
            PlayerTable = new TableView();
            ComputerTable = new TableView();
            Player = new Player
            {
                GamePlayed = 0,
                GameWin = 0,
                Name = "Default",
                Record = 0
            };
        }
        public void ComputerRound()
        {
            throw new NotImplementedException();
        }

        public void FinalScore()
        {
            throw new NotImplementedException();
        }

        public void InputName()
        {
            Console.Write("Введите имя: ");
            Player.Name = Console.ReadLine();
            bool isDefault = true;
            if (Player.Name != "" || Player.Name != null)
            {
                foreach (var item in Player.Name)
                {
                    if (item != ' ')
                    {
                        isDefault = false;
                    }
                }
                if (isDefault)
                {
                    Player.Name = "Default";
                }
            }

        }

        public void PlayerRound()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            Console.WriteLine("\t\tВаше поле");
            PlayerTable.Show(PlayerShips);
            Console.SetCursorPosition(60, 0);
            Console.WriteLine("\t\tПоле компьютера");
            ComputerTable.ShowWithCursorParametr(PlayerShips, 60, 0);
            ProccessArrangement();
        }

        public void ProccessArrangement()
        {

            int type = 0;


            bool isTruePunct = false;
            Console.WriteLine("Вы должны расставить корабли. В запасе:");
            Console.WriteLine($"1. Катер (однапалубный) - {boat}");
            Console.WriteLine($"2. Эсминцы (двухпалубный) - {destroyers}");
            Console.WriteLine($"3. Крейсеры (трёхпалубный) - {cruisers}");
            Console.WriteLine($"4. Линкор (четырёхпалубный) - {battleship}\n");
            while (!isTruePunct)
            {
                Console.Write($"Введите номер корабля: ");
                string punct = Console.ReadLine();
                switch (punct)
                {
                    case "1":
                        type = 1;
                        if (boat == 0)
                        {
                            Console.WriteLine("Кораблей такого типа нет в запасе");
                        }
                        else
                        {
                            isTruePunct = true;
                        }
                        break;
                    case "2":
                        type = 2;
                        if (destroyers == 0)
                        {
                            Console.WriteLine("Кораблей такого типа нет в запасе");
                        }
                        else
                        {
                            isTruePunct = true;
                        }
                        break;
                    case "3":
                        type = 3;
                        if (cruisers == 0)
                        {
                            Console.WriteLine("Кораблей такого типа нет в запасе");
                        }
                        else
                        {
                            isTruePunct = true;
                        }
                        break;
                    case "4":
                        type = 4;
                        if (battleship == 0)
                        {
                            Console.WriteLine("Кораблей такого типа нет в запасе");
                        }
                        else
                        {
                            isTruePunct = true;
                        }
                        break;
                    default:
                        Console.WriteLine("Введите число от 1 - 4");
                        break;
                }
            }
            string alph = "";
            bool isTrueAlph = false;
            while (!isTrueAlph)
            {
                Console.Write("Введите букву: ");
                alph = Console.ReadLine();
                if (alph != "A" && alph != "B" && alph != "C" && alph != "D" && alph != "E" && alph != "F" && alph != "G" && alph != "H" && alph != "I" && alph != "J")
                {
                    Console.WriteLine("Вы должны ввести букву от A-J (буквы прописные)");
                }
                else
                {
                    isTrueAlph = true;
                }
            }
            string number = "";
            bool isTrueNumber = false;
            while (!isTrueNumber)
            {
                Console.Write("Введите число: ");
                number = Console.ReadLine();
                if (number != "1" && number != "2" && number != "3" && number != "4" && number != "5" && number != "6" && number != "7" && number != "8" && number != "9" && number != "10")
                {
                    Console.WriteLine("Вы должны ввести число от 1-10");
                }
                else
                {
                    isTrueNumber = true;
                }
            }
            int alphDigit = 0;
            if (alph == "A")
            {
                alphDigit = 1;
            }
            else if (alph == "B")
            {
                alphDigit = 2;
            }
            else if (alph == "C")
            {
                alphDigit = 3;
            }
            else if (alph == "D")
            {
                alphDigit = 4;
            }
            else if (alph == "E")
            {
                alphDigit = 5;
            }
            else if (alph == "F")
            {
                alphDigit = 6;
            }
            else if (alph == "G")
            {
                alphDigit = 7;
            }
            else if (alph == "H")
            {
                alphDigit = 8;
            }
            else if (alph == "I")
            {
                alphDigit = 9;
            }
            else if (alph == "J")
            {
                alphDigit = 10;
            }
            if (type == 1)
            {
                PositionShip boatPos = new PositionShip
                {
                    Alph = alphDigit,
                    Number = Int32.Parse(number)
                };
                Console.WriteLine("Корабль поставлен!");
                Console.Clear();
                PlayerShips.Add(boatPos);
            }
            else
            {
                Console.WriteLine("1. Вверх");
                Console.WriteLine("2. Вниз");
                Console.WriteLine("3. Вправо");
                Console.WriteLine("4. Влево");
                string direction = "";
                bool isTrueDirection = false;
                while (!isTrueDirection)
                {
                    Console.Write("Выберите направление для корабля: ");
                    direction = Console.ReadLine();
                    if (direction != "1" && direction != "2" && direction != "3" && direction != "4")
                    {
                        Console.WriteLine("Вы должны ввести число от 1-4");
                    }
                    else
                    {
                        if (direction == "1")
                        {
                            if (Int32.Parse(number) - type < 0)
                            {
                                Console.WriteLine("Корабль невозможно поставить");
                            }
                            else
                            {
                                isTrueDirection = true;
                            }
                        }
                        else if (direction == "2")
                        {
                            if (Int32.Parse(number) + type > 10)
                            {
                                Console.WriteLine("Корабль невозможно поставить");
                            }
                            else
                            {
                                isTrueDirection = true;
                            }
                        }
                        else if (direction == "3")
                        {
                            if (Char.Parse(number) + type > 74)
                            {
                                Console.WriteLine("Корабль невозможно поставить");
                            }
                            else
                            {
                                isTrueDirection = true;
                            }
                        }
                        else if (direction == "4")
                        {
                            if (Char.Parse(number) - type < 65)
                            {
                                Console.WriteLine("Корабль невозможно поставить");
                            }
                            else
                            {
                                isTrueDirection = true;
                            }
                        }
                        else
                        {
                            isTrueNumber = true;
                        }
                    }
                }               

                for (int i = 0; i < type; i++)
                {
                    PositionShip position = new PositionShip();
                    if (direction == "1")
                    {
                        position = new PositionShip
                        {
                            Alph = alphDigit,
                            Number = Int32.Parse(number) - i
                        };
                    }
                    else if (direction == "2")
                    {
                        position = new PositionShip
                        {
                            Alph = alphDigit,
                            Number = Int32.Parse(number) + i
                        };
                    }
                    else if (direction == "3")
                    {
                        position = new PositionShip
                        {
                            Alph = alphDigit + i,
                            Number = Int32.Parse(number)
                        };
                    }
                    else if (direction == "4")
                    {
                        position = new PositionShip
                        {
                            Alph = alphDigit - i,
                            Number = Int32.Parse(number)
                        };
                    }

                    PlayerShips.Add(position);
                }

                Console.WriteLine("Корабль поставлен!");
                Console.Clear();
            }
            if (type == 1)
            {
                boat--;
            }
            else if (type == 2)
            {
                destroyers--;
            }
            else if (type == 3)
            {
                cruisers--;
            }
            else if (type == 4)
            {
                battleship--;
            }
            Start();
        }
    }
}
