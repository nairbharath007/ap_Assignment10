using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketerAge.Model
{
    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Player(int id, string name, int age) 
        {
            Id = id; 
            Name = name;
            Age = age;
        }
        public string ShowCustomerDetails()
        {
            return $"Id : {Id}\n Name : {Name}\n Age : {Age} ";
        }
        public static Player WhoIsElder(Player[] players)
        {
            int maxAge = players[0].Age;
            Player maxPlayer = null;
            for (int i = 0; i < players.Length; i++) 
            {
                if (players[i].Age > maxAge)
                {
                    maxAge = players[i].Age;
                    maxPlayer = players[i];
                }
            }
            return maxPlayer;
        }
    }
}
