using System.Spatial;

namespace MeetingFriendsPOC
{
    public class Friend
    {
        public Friend(string name, Geography pointOfOrigin)
        {
            Name = name;
            PointOfOrigin = pointOfOrigin;
        }
        public string Name { get; set; } = string.Empty;
        public Geography PointOfOrigin { get; set; }
        public TimeOnly? TravelTime { get; set; }
        public Double? DistanceToDestination { get; set; }

    }
}
