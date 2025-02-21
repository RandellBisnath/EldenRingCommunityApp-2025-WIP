using EldenRingCommunityApp.Models.JoinTables;

namespace EldenRingCommunityApp.Models.SubClasses
{
    public class Weapon
    {
        public int WeaponID { get; set; }
        public string Name { get; set; }
        public int StrengthRequirement { get; set; }
        public int DexterityRequirement { get; set; }
        public int IntelligenceRequirement { get; set; }
        public int FaithRequirement { get; set; }
        public int ArcaneRequirement { get; set; }
        public int PhysicalDamage { get; set; }
        public int MagicDamage { get; set; }
        public int FireDamage { get; set; }
        public int LightningDamage { get; set; }
        public int HolyDamage { get; set; }
        public int CritModifier { get; set; }
        public int PhysicalGuard { get; set; }
        public int MagicGuard { get; set; }
        public int FireGuard { get; set; }
        public int LightningGuard { get; set; }
        public int HolyGuard { get; set; }
        public int Boost { get; set;}
        public string StrengthScaling { get; set; }
        public string DexterityScaling { get; set; }
        public string IntelligenceScaling { get; set; }
        public string FaithScaling { get; set; }
        public string ArcaneScaling { get; set; }
        public int Weight { get; set; }
        public string PassiveEffect { get; set; }
        public bool Paired { get; set; }

        public int WeaponTypeID { get; set; }
        public WeaponType WeaponType { get; set; }

        public int AshOfWarID { get; set; }
        public AshOfWar AshOfWar { get; set; }

        public ICollection<BuildWeapon> BuildWeapons { get; set; } = new List<BuildWeapon>(); 
        }   
    }
    

