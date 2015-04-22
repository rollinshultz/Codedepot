using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codedepot.Models
{
    public class Portfolio
    {
        [Key]
        public int memberID { get; set; }
        public string userName { get; set; }
        public string resumePath { get; set; }
        public string contributionList { get; set; }
        public string projects { get; set; }
    }
}