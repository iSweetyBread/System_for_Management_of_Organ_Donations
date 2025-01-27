using logic.infoObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public abstract class Donation : SqlObject
    {
        public int Id { get; set; }
        public int? PlaceId { get; set; }
        public DateTime? DonationDate { get; set; }
    }
}
