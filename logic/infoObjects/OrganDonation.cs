using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class OrganDonation : Donation
    {
        public int? DonorId { get; set; }
        public string Organ { get; set; }
        public string Status { get; set; }

        public OrganDonation(int id, int? donorId, string organ, DateTime? donationDate, int placeId, string status)
        { 
            this.Id = id;
            this.parameters.Add(new SqlParameter("@Organ_id", this.Id));
            this.DonorId = donorId;
            if (donorId is null)
            {
                this.parameters.Add(new SqlParameter("@Donor_id", "NULL"));
                parameters[1].Value = DBNull.Value;
            }
            else
            {
                this.parameters.Add(new SqlParameter("@Donor_id", this.DonorId));
            }
            this.Organ = organ;
            this.parameters.Add(new SqlParameter("@Organ", this.Organ));
            this.DonationDate = donationDate;
            if (donationDate is null)
            {
                this.parameters.Add(new SqlParameter("@Extraction_date", "NULL"));
                parameters[3].Value = DBNull.Value;
            }
            else
            {
                this.parameters.Add(new SqlParameter("@Extraction_date", this.DonationDate));
            }
            this.PlaceId = placeId;
            this.parameters.Add(new SqlParameter("@Place_id", this.PlaceId));
            this.Status = status;
            this.parameters.Add(new SqlParameter("@Status", this.Status));
        }
        public OrganDonation(Dictionary<string, object> data)
        { 
            this.Id = int.Parse(data["Organ_id"].ToString());
            try { this.DonorId = int.Parse(data["Donor_id"].ToString()); } catch { this.DonorId = null; }
            this.Organ = data["Organ"].ToString();
            try { this.DonationDate = DateTime.Parse(data["Extraction_date"].ToString()); } catch { this.DonationDate = null; }
            try { this.PlaceId = int.Parse(data["Place_id"].ToString()); } catch { this.PlaceId = null; }
            this.Status = data["Status"].ToString();
        }
        public override int GetHashCode()
        {
            return 5;
        }
    }
}
