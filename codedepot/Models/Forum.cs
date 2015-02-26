using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codedepot.Models
{
    public class Forum
    {
        public int forumThreadID { get; set; }
        public string forumThreadPoster { get; set; }
        public string threadPath { get; set; }
    }
}