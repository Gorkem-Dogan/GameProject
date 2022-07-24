using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class PlayerManager : IPlayerService
    {
        List<Player> PlayerList;
        public PlayerManager()
        {
            PlayerList = new List<Player>();
        }

        public void Add(Player player)
        {
            PlayerList.Add(player);
        }

        public void Remove(Player player)
        {
            PlayerList.Remove(player);
        }


        public void Update(Player player)
        {
            Console.WriteLine("The Players have been updated");
        }
        public void ShowPlayers( ) 
        
        {
            foreach (Player item in PlayerList)
            {
                Console.WriteLine("The nickname of the player: " + item.Nickname +" and name is: "+ item.FirstName);
            }
        
        }    
    }
}
