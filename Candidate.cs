using System;
using System.Collections.Generic;
using System.Linq;
using System.Spatial;
using System.Text;
using System.Threading.Tasks;

namespace MeetingFriendsPOC
{
    public class Candidate
    {
        public Candidate(string name, Geography location)
        {
            Name = name;
            Location = location;
        }
        public string Name { get; set; } = string.Empty;
        public Geography Location { get; set; }
    }
}
