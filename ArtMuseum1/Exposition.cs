using System;

namespace ArtMuseum1
{
    public class Exposition
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime beginDate { get; set; }
        public DateTime endDate { get; set; }
        public bool isCurrent { get; set; }
    }
}