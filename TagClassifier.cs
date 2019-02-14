using System.Linq;
using System.Xml;

namespace GPXparser {

    public static class TagClassifier {

        internal static readonly string[] trackTags = new string[] { "trk", "rte" };

        internal static readonly string[] waypointTags = new string[] { "trkpt", "rtept", "wpt" };

        public static bool IsTrack(this XmlReader tag) {
            return trackTags.Contains(tag.Name);
        }

        public static bool IsWaypoint(this XmlReader tag) {
            return waypointTags.Contains(tag.Name);
        }
        
    }
    
}
