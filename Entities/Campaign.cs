using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation_Management_System_alpha_ver.Entities
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public float CampaignBalance { get; set; }
        //public int Quantity { get; set; }
        public int ProjectId { get; set; }
        //public double Balance { get; set; }
    }
}
