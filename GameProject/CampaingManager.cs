using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaingManager : ICampaingService
    {
        public void AddCampaign(Campaign campaing)
        {
            Console.WriteLine(campaing.CampaignName + " kampanyası eklendi:" + "%"+ campaing.CampaingDiscount + " indirim uygulandı");
        }

        public void DeleteCampaign(Campaign campaing)
        {
            Console.WriteLine(campaing.CampaignName + " kampanyası silindi.");
        }

        public void UpdateCampaign(Campaign campaing)
        {
            Console.WriteLine(campaing.CampaignName + " kapmanyası silindi.");
        }
    }
}
