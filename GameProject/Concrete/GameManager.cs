using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void GameCampaign(Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " " + campaign.CampaignName + " has campaign");
        }

        public void GameOrder(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " game " + gamer.FirstName + " " + gamer.LastName + " " + game.GamePrice + "$ sold");

        }
    }
}
