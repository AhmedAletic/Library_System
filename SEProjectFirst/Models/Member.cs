using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEProjectFirst.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public  DateTime dateOfBirth { get; set; }
        public DateTime dateOfMembership { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string MembershipNumber { get; set; }
    }
}