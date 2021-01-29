using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaingService
    {
        void AddCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);

    }
}
