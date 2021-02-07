using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameSellManager :ISellService
    {

        public void Sell(Game game, Gamer gamer,Campaign campaign=null)
        {
            Console.WriteLine("{0} Oyunu {1} tarafıdan  {2} TL'ye satın alındı.", game.GameName, gamer.FristName, game.UnitPrice);
        }
    }
}
