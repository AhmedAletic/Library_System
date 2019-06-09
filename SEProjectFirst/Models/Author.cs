using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEProjectFirst.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string Nationality { get; set; }
        public bool Live { get; set; }

        public string FullName {
            get
            {
                return string.Format("{0} {1}", Name, LastName);
            }
            set { }
        }
    }
}