using System;
using System.Collections.Generic;
using System.Text;

namespace BloodDonationApp.Models
{
    public class Donor
    {
        public int ID { get; set; }
        public int AreaID { get; set; }
        public int BloodGroupID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Image { get; set; }
        public Area Area { get; set; }
        public BloodGroup BloodGroup { get; set; }
    }
}
