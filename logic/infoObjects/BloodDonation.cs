using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class BloodDonation : Donation
    {
        public int Amount { get; set; }

        public BloodDonation(DateTime donationDate, int amount, int donorId, int placeId)
        { 
            this.DonationDate = donationDate;
            this.parameters.Add(new SqlParameter("@Donation_date", this.DonationDate));
            this.Amount = amount;
            this.parameters.Add(new SqlParameter("@Amount", this.Amount));
            this.Id = donorId;
            this.parameters.Add(new SqlParameter("@Bdonor_id", this.Id));
            this.PlaceId = placeId;
            this.parameters.Add(new SqlParameter("@Place_id", this.PlaceId));
        }
        public BloodDonation(Dictionary<string, object> data) 
        {
            this.Id = int.Parse(data["Bdonor_id"].ToString());
            this.DonationDate = DateTime.Parse(data["Donation_date"].ToString());
            this.Amount = int.Parse(data["Amount"].ToString());
            this.PlaceId = int.Parse(data["Place_id"].ToString());
        }

        public override int GetHashCode()
        {
            return 4;
        }
    }
}
