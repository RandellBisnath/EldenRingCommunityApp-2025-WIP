using EldenRingCommunityApp.Models.JoinTables;
using EldenRingCommunityApp.Models.SubClasses;
using Microsoft.Identity.Client;

namespace EldenRingCommunityApp.Models
{
    public class Build
    {
        public int BuildID { get; set; }
        public string Name { get; set; }
        public int Vigor { get; set; }
        public int Mind { get; set; }
        public int Endurance { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Faith { get; set; }
        public int Arcane { get; set; }

        public string UserID { get; set; }
        public User User { get; set; } = null!;

        public int StartingClassID { get; set; }
        public StartingClass StartingClass { get; set; } = null!;

        public int HelmetID { get; set; }
        public Helmet Helmet { get; set; } = null!;

        public int ChestArmorID { get; set; }
        public ChestArmor ChestArmor { get; set; } = null!;
        
        public int GauntletsID { get; set; }
        public Gauntlets Gauntlets { get; set; } = null!;

        public int LegArmorID { get; set; }
        public LegArmor LegArmor { get; set; } = null!;

        public ICollection<BuildWeapon> BuildWeapons { get; set; } = new List<BuildWeapon>();
        public ICollection<BuildSpells> BuildSpells { get; set; } = new List<BuildSpells>();
        public ICollection<BuildTalismans> BuildTalismans { get; set; } = new List<BuildTalismans>();

        public int getLevel()
        {
            int level = 0;

            level = Vigor + Mind + Endurance + Strength + Dexterity + Intelligence + Faith + Arcane;

            return level;
        }
        }
}
