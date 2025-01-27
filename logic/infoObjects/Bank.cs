using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class Bank : Place
    {
        public Bank(int id, string city, string address, string contactInfo)
        {
            this.Id = id;
            this.parameters.Add(new SqlParameter("@Place_id", this.Id));
            this.City = city;
            this.parameters.Add(new SqlParameter("@City", this.City));
            this.Address = address;
            this.parameters.Add(new SqlParameter("@Address", this.Address));
            this.ContactInfo = contactInfo;
            this.parameters.Add(new SqlParameter("@Contact_info", this.ContactInfo));
        }
        public Bank(Dictionary<string, object> data)
        {
            this.Id = int.Parse(data["Place_id"].ToString());
            this.City = data["City"].ToString();
            this.Address = data["Address"].ToString();
            this.ContactInfo = data["Contact_info"].ToString();
        }
        public override int GetHashCode()
        {
            return 7;
        }
    }
}
