using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameService
    {
        void GameCampaign(Game game, Campaign campaign);
        void GameOrder(Game game, Gamer gamer);

    }
}
