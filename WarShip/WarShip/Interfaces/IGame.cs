using System;
using System.Collections.Generic;
using System.Text;

namespace WarShip.Interfaces
{
    public interface IGame
    {
        public void ProccessArrangement();
        public void Start();
        public void FinalScore();
        public void InputName();
        public void PlayerRound();
        public void ComputerRound();
    }
}
