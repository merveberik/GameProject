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
            Game game3 = new Game { GameName = "Sudoku", GamePrice = 30 };
            Game game4 = new Game { GameName = "Word Game", GamePrice = 15 };

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
                NewGame:
                    Console.WriteLine("Do you want to get a new game: Y or N");
                    string userdecision2 = (Console.ReadLine().ToUpper());
                    switch (userdecision2)
                    {
                        case "Y":
                        StartGame:
                        
                            Console.WriteLine("PLease choose a new game: 1 - Snake, 2 - Sudoku, 3 - Word Game");
                            int UserChoice = int.Parse(Console.ReadLine());
                            switch (UserChoice)
                            {
                                case 1:
                                    gameManager.GameOrder(game1, gamer2);
                                    break;
                                case 2:
                                    gameManager.GameOrder(game3, gamer2);
                                    break;
                                case 3:
                                    gameManager.GameOrder(game4, gamer2);
                                    break;
                                default:
                                    Console.WriteLine("your choice is invalid");
                                    goto StartGame;
                            }
                            goto Start;
                        case "N":
                            Console.WriteLine("Thanks");
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            goto NewGame;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    goto Decision;
            }
           


        }
    }
}
