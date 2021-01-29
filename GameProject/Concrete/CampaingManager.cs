using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaingManager : ICampaingService
    {
        public void AddCampaign(Campaign campaing)
        {
            Console.WriteLine(campaing.CampaignName + " was added campaign:" + "%"+ campaing.CampaingDiscount + " has discount");
        }

        public void DeleteCampaign(Campaign campaing)
        {
            Console.WriteLine(campaing.CampaignName + " was deleted.");
        }

        public void UpdateCampaign(Campaign campaing)
        {
            Console.WriteLine(campaing.CampaignName + " was updated.");
        }
    }
}
