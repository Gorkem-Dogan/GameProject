using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameMarketPlatformManager : IGameMarketPlatformService
    {
        List<Games> games;
        public GameMarketPlatformManager()
        {
            games = new List<Games>();
        }

        public void Add(Games game)
        {
            games.Add(game);
        }

        public void Remove(Games game)
        {
            games.Remove(game);
        }


        public void Update(Games game)
        {
            Console.WriteLine("Your gaming library has been Updated");
        }


        public void ShowGamesList()
        {
            foreach (Games item in games)
            {
                Console.WriteLine("oyun: " + item.Id + " " + item.GameName + "= " + item.GamePrice + " TL");
            }
        }

        
        public void Sell(Player player, Games game)
        {
            Console.WriteLine("Dear " + player.Nickname + " " + game.GameName + " has been added to your gaming library for " + game.GamePrice + " TL please check it");
        }
        public void Sell(Player player, Games game, Discount discount) 
        {
            double DiscountedFee = (game.GamePrice - (discount.DiscountRate * game.GamePrice));
            Console.WriteLine("Before the " + discount.DiscountName + " Discount this games price was: " + game.GamePrice );
            Console.WriteLine("After the " + discount.DiscountName + " Discount this games price is: " + DiscountedFee);
            Console.WriteLine("Your purchase for: "+game.GameName+"'s price is: " +DiscountedFee+ " payment has been taken off from your account successfully ");
        }
    }
}
