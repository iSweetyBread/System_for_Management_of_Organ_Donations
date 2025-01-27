using logic.infoObjects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public abstract class Person : SqlObject
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BloodType { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}
