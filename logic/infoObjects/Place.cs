using logic.infoObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public abstract class Place : SqlObject
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ContactInfo { get; set; }
    }
}
