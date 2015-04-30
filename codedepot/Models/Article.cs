using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codedepot.Models
{
    public class Article
    {
        [Key]
        public int articleID { get; set; }
        public string articleTitle { get; set; }
        public string articleDescription { get; set; }
        public string articlePath { get; set; }
        public string author { get; set; }
        public DateTime date { get; set; }
        public decimal rating { get; set; }
        public string language { get; set; }
    }
}