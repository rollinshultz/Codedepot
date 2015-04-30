using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codedepot.Models
{
    public class Code
    {
        [Key]
        public int snippetID { get; set; }
        public string snippetTitle { get; set; }
        public string snippetDescription { get; set; }
        public DateTime date { get; set; }
        public string author { get; set; }
        public string snippetPath { get; set; }
        public string language { get; set; }
        public decimal rating { get; set; }
        public List<Code> snippets { get; set; }
    }
}