namespace EldenRingCommunityApp.Models.SubClasses
{
    public class WeaponType
    {
        public int WeaponTypeID { get; set; }
        public string Type { get; set; }
        public ICollection<Weapon> Weapons { get; set; } = new List<Weapon>();
    }
}
