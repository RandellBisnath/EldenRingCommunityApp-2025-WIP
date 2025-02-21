using Microsoft.Build.Framework;

namespace EldenRingCommunityApp.Models.SubClasses
{
    public class StartingClass
    {
        public int StartingClassID { get; set; }
        public string Name { get; set; }
        public int Vigor { get; set; }
        public int Mind { get; set; }
        public int Endurance { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Faith { get; set; }
        public int Arcane { get; set; }

        public ICollection<Build> Builds { get; set; } = new List<Build>();
    }
}
