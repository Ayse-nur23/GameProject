using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISellService
    {
        public void Sell(Game game, Gamer gamer, Campaign campaign=null);
    }
}
