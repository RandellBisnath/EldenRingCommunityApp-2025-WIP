namespace EldenRingCommunityApp.Models.SubClasses
{
    public class AshOfWar
    {
        public int AshOfWarID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Affinity { get; set; }
        public ICollection<Weapon> Weapons { get; set; } = new List<Weapon>();
    }
}
