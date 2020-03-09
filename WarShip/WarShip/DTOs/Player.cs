using System;
using System.Collections.Generic;
using System.Text;

namespace WarShip.DTOs
{
    public class Player
    {
        public Guid Id { get; set;} = Guid.NewGuid();
        public string Name { get; set;}
        public int Record { get; set;}
        public int GamePlayed { get; set;}
        public int GameWin { get; set;}
    }
}
