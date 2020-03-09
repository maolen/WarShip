using System;
using System.Collections.Generic;
using System.Text;
using WarShip.Interfaces;
using WarShip.Views;

namespace WarShip.Function
{
    public class WorkWithMenu : IWorkWithMenu
    {
        public int _currentPunct;
        public MenuView Menu { get; private set;}
        public RecordView Record { get; set;}
        public Game Game { get; set;}
        public WorkWithMenu()
        {
            _currentPunct = 0;
            Menu = new MenuView();
            Record = new RecordView();
        }
        public void DownPunctMenu()
        {
            _currentPunct++;
            if (_currentPunct > Menu.Puncts.Count - 1)
            {
                _currentPunct = Menu.Puncts.Count - 1;
                Console.Clear();
                Menu.Show(_currentPunct);
            }
            else
            {
                Console.Clear();
                Menu.Show(_currentPunct);
            }
        }

        public void UpPunctMenu()
        {
            _currentPunct--;
            if (_currentPunct < 0)
            {
                _currentPunct = 0;
                Console.Clear();
                Menu.Show(_currentPunct);
            }
            else
            {
                Console.Clear();
                Menu.Show(_currentPunct);
            }
        }

        public void EnterPunctMenu()
        {
            if (Menu.Puncts[_currentPunct] == "Играть")
            {
                Console.Clear();
                Game game = new Game();
                game.InputName();
                Console.Clear();
                game.Start();
            }
            else if (Menu.Puncts[_currentPunct] == "Рекорды")
            {
                Console.Clear();
                Record.Show();
            }
        }
    }
}
