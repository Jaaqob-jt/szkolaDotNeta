using System;
using System.Collections.Generic;
using System.Text;

namespace CMMS_Draft
{
    public class Entry
    {
        private static int IdSeed = 10001;
        public int EntryId { get; private set; }
        public string Description { get; set; }
        public DateTime DatePosted 
        { get; private set; }

        public Entry(string description)
        {
            EntryId = IdSeed;
            Description = description;
            DatePosted = DateTime.Now;

            IdSeed++;
        }
        public Entry(int id, string description)
        {
            EntryId = id;
            Description = description;
            DatePosted = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{EntryId}.\t >>{DatePosted.ToShortTimeString()}\t{Description}";
        }
    }
}
