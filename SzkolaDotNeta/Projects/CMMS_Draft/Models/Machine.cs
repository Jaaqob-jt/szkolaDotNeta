using System;
using System.Collections.Generic;
using System.Text;

namespace CMMS_Draft
{
    public class Machine
    {
        internal static int IdSeed = 1000;
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public List<Entry> Entries { get; set; }

        public override string ToString()
        {
            return $"{Id}.\t{Category}\t{Name}";

        }
    }
}
