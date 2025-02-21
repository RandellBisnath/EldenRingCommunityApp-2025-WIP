using EldenRingCommunityApp.Models.JoinTables;

namespace EldenRingCommunityApp.Models.SubClasses
{
    public class Spell
    {
        public int SpellID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int FPCost { get; set; }
        public int StaminaCost { get; set; }
        public int SlotsUsed { get; set; }
        public int IntelligenceRequirement { get; set; }
        public int FaithRequirement { get; set;}
        public int ArcaneRequirement { get; set; }

        public ICollection<BuildSpells> BuildSpells { get; set; } = new List<BuildSpells>(); 
    }
}
