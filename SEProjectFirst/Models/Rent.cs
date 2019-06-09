using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEProjectFirst.Models
{
    public class Rent
    {
        public int RentID { get; set; }

        public int BookID { get; set; }
        public virtual Book Book { get; set; }

        public int MemberId { get; set; }
        public virtual Member Member { get; set; }

        public DateTime RentDate { get; set; }
    }
}