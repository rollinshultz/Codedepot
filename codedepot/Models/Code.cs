using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codedepot.Models
{
    public class Code
    {
        public int codeSnippetID { get; set; }
        public string snippetTitle { get; set; }
        public string codeSnippetDescription { get; set; }
        public string codeSnippetPath { get; set; }
        public string author { get; set; }
    }
}