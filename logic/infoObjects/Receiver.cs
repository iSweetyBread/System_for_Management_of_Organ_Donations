using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class Receiver : Person
    {
        public int OrganId { get; set; }
        public int HospitalId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime? OperationDate { get; set; }
        public string OrganStatus { get; set; }
        public string Priority { get; set; }

        public Receiver(int id, string firstName, string lastName, DateTime birthdate, string bloodType, string city, string address, int hospitalId, DateTime registrationDate, int organId)
        {
            this.Id = id;
            this.parameters.Add(new SqlParameter("@Receiver_id", this.Id));
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
            this.HospitalId = hospitalId;
            this.parameters.Add(new SqlParameter("@Hospital_id", this.HospitalId));
            this.RegistrationDate = registrationDate;
            this.parameters.Add(new SqlParameter("@Registration_date", this.RegistrationDate));
            this.OrganStatus = "pending";
            this.parameters.Add(new SqlParameter("@Organ_status", this.OrganStatus));
            this.Priority = "low";
            this.parameters.Add(new SqlParameter("@Priority", this.Priority));
            this.OrganId = organId;
            this.parameters.Add(new SqlParameter("@Organ_id", this.OrganId));
        }
        public Receiver(Dictionary<string, object> data)
        {
            this.Id = int.Parse(data["Receiver_id"].ToString());
            this.FirstName = data["First_name"].ToString();
            this.LastName = data["Last_name"].ToString();
            this.BirthDate = DateTime.Parse(data["Birth_date"].ToString());
            this.BloodType = data["Blood_type"].ToString();
            this.OrganId = int.Parse(data["Organ_id"].ToString());
            this.City = data["City"].ToString();
            this.Address = data["Address"].ToString();
            this.HospitalId = int.Parse(data["Hospital_id"].ToString());
            this.RegistrationDate = DateTime.Parse(data["Registration_date"].ToString());
            try { this.OperationDate = DateTime.Parse(data["Operation_date"].ToString()); } catch { this.OperationDate = null; }
            this.OrganStatus = data["Organ_status"].ToString();
            this.Priority = data["Priority"].ToString();
        }
        public override int GetHashCode()
        {
            return 3;
        }
    }
}
