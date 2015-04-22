using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codedepot.Models
{
    public class Forum
    {
        [Key]
        public int forumThreadID { get; set; }
        public string forumThreadPosterID { get; set; }
        public string threadPath { get; set; }
    }
}