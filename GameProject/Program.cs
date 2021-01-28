using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1996,
                FirstName = "MERVE",
                LastName = "BERİK",
                IdentityNumber = 12345
            });
            Gamer gamer2 = new Gamer
            {
                Id = 1,
                BirthYear = 1996,
                FirstName = "MERVE",
                LastName = "BERİK",
                IdentityNumber = 12345
            };
            CampaingManager campaingManager = new CampaingManager();
            Campaign campaign1=new Campaign { CampaignName = "Summer", CampaingDiscount = 25 };           campaingManager.AddCampaign(campaign1);
            campaingManager.UpdateCampaign(new Campaign { CampaignName = "Summer" });

            GameManager gameManager = new GameManager();
            Game game1 = new Game { GameName = "Snake", GamePrice = 25 };
            gameManager.GameCampaign(game1, campaign1);
            gameManager.GameOrder(game1, gamer2);
            Game game2 = new Game { GameName = "Zuma", GamePrice = 0 };

        
        Decision:
            Console.WriteLine("Do you want to get free 'Zuma' game: Y or N");
        
            string userdecision = (Console.ReadLine().ToUpper());
            switch (userdecision)
            {
                case "Y":
                    gameManager.GameOrder(game2, gamer2);
                    goto Start;
                case "N":
                Start:
                    Console.WriteLine("Go to the menu for other games.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    goto Decision;
            }
        
            

        }
    }
}
