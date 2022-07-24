using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IGameMarketPlatformService
    {
        void Add(Games game);
        void Remove(Games game);
        void Update(Games game);
        void ShowGamesList();
        void Sell(Player player, Games game);
        void Sell(Player player, Games games, Discount discount);

    }
}
