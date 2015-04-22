using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codedepot.Models
{
    public class Comment
    {
        [Key]
        public int threadID { get; set; }
        public int commentID { get; set; }
        public bool isReply { get; set; }
        public string threadSubject { get; set; }
        public string commentPoster { get; set; }
        public string commentPath { get; set; }
    }
}