using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class OrganDonor : Person
    {
        public OrganDonor(int id, string firstName, string lastName, DateTime birthdate, string bloodType, string city, string address)
        {
            this.Id = id;
            this.parameters.Add(new SqlParameter("@Donor_id", this.Id));
            this.FirstName = firstName;
            this.parameters.Add(new SqlParameter("@First_name", this.FirstName));
            this.LastName = lastName;
            this.parameters.Add(new SqlParameter("@Last_name", this.LastName));
            this.BirthDate = birthdate;
            this.parameters.Add(new SqlParameter("@Birth_date", this.BirthDate));
            this.BloodType = bloodType;
            this.parameters.Add(new SqlParameter("@Blood_type", this.BloodType));
            this.City = city;
            this.parameters.Add(new SqlParameter("@City", this.City));
            this.Address = address;
            this.parameters.Add(new SqlParameter("@Address", this.Address));
        }
        public OrganDonor(Dictionary<string, object> data)
        {
            this.Id = int.Parse(data["Donor_id"].ToString());
            this.FirstName = data["First_name"].ToString();
            this.LastName = data["Last_name"].ToString();
            this.BirthDate = DateTime.Parse(data["Birth_date"].ToString());
            this.BloodType = data["Blood_type"].ToString();
            this.City = data["City"].ToString();
            this.Address = data["Address"].ToString();
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }
}
