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
        public int codeSnippetID { get; set; }
        public string snippetTitle { get; set; }
        public string codeSnippetDescription { get; set; }
        public DateTime date { get; set; }
        public string author { get; set; }
        public string codeSnippetPath { get; set; }
        public string language { get; set; }
        public List<Code> snippets { get; set; }
    }
}