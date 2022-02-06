using System;

namespace NewCSharpConcepts
{
    public class Memo : Document
    {
        public string? MemoTo { get; set; }
        public string? MemoFrom { get; set; }
        public DateTime MemoDateTime { get; set; }
        public string? MemoSubject { get; set; }

    }
}