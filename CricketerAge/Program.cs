using CricketerAge.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketerAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(23, "Michael Jordan", 40);
            Player player2 = new Player(11, "Sunil Chhetri", 39);

            Player[] players =
            {
                player1,
                player2,
                new Player(18, "Virat Kohli", 34),
                new Player(7,"MS Dhoni", 42)
            };

            foreach (Player player in players)
            {
                Console.WriteLine(player.ShowCustomerDetails());
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine($"Eldest player details: \n{Player.WhoIsElder(players).ShowCustomerDetails()}");
        }
    }
}
