using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEProjectFirst.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int NumOfPages { get; set; }

        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }

        public int PublisherID { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}