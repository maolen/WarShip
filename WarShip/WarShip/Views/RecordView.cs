using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarShip.DBContext;
using WarShip.DTOs;
using WarShip.Interfaces;

namespace WarShip.Views
{
    public class RecordView : IRecordView
    {
        public List<Player> Players { get; set;}
        public RecordView()
        {
            using (var context = new Context())
            {
                Players = context.Players.ToList();
            }
            Players = Players.OrderByDescending(p => p.Record).ToList();
        }
        public void Show()
        {
            Console.WindowHeight = 50;
            Console.WindowWidth = 150;
            Console.Write("\tИмя\t\t|\t\tИгр сыграно\t\t|\tИгр выиграно\t\t|\t\tОчков\t|\n");
            Console.WriteLine("------------------------|---------------------------------------|-------------------------------|----------------------|");
            foreach(var player in Players)
            {
                Console.WriteLine($"\t{player.Name}\t\t|\t\t{player.GamePlayed}\t\t\t|\t\t{player.GameWin}\t\t|\t\t{player.Record}\t|");
                Console.WriteLine("------------------------|---------------------------------------|-------------------------------|----------------------|");
            }
        }
    }
}
