using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class CampaingSellManager :ISellService
    {

        public void Sell(Game game, Gamer gamer, Campaign campaign=null)
        {
            double price = game.UnitPrice - (game.UnitPrice * campaign.campaignDiscount / 100);
            Console.WriteLine("{0} Oyunu {1} tarafıdan kampanyalı fiyatı {2} TL'ye satın alındı.", game.GameName, gamer.UserName, price);
        }
    }
}
