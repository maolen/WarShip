using System;
using System.Collections.Generic;
using System.Text;
using WarShip.Function;

namespace WarShip.Interfaces
{
    public interface ITableView
    {
        public void Show(List<PositionShip> position);
        public void ShowWithCursorParametr(List<PositionShip> position, int col, int row);
    }
}
