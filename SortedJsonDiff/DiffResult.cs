using System.Collections.Generic;

namespace SortedJsonDiff
{
    public class DiffResult
    {
        public DiffStatus Status { get; set; }
        public List<string> Elements { get; set; }
    }
}

