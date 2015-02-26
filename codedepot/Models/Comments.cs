using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codedepot.Models
{
    public class Comments
    {
        public int threadID { get; set; }
        public int commentID { get; set; }
        public bool isReply { get; set; }
        public string threadSubject { get; set; }
        public string commentPoster { get; set; }
        public string commentPath { get; set; }
    }
}