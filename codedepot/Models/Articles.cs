using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codedepot.Models
{
    public class Articles
    {
        public int articleID { get; set; }
        public string articleTitle { get; set; }
        public string articleDescriprion { get; set; }
        public string articlePath { get; set; }
        public string author { get; set; }
    }
}