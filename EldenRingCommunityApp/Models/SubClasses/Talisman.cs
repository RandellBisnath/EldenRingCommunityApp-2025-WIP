using EldenRingCommunityApp.Models.JoinTables;

namespace EldenRingCommunityApp.Models.SubClasses
{
    public class Talisman
    {
        public int TalismanID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<BuildTalismans> BuildTalismans { get; set; } = new List<BuildTalismans>();
    }
}
