namespace EldenRingCommunityApp.Models.SubClasses
{
    public class Gauntlets
    {
        public int GauntletsID { get; set; }
        public string Name { get; set; }
        public double PhysicalResist { get; set; }
        public double VsStrike { get; set; }
        public double VsSlash { get; set; }
        public double VsPierce { get; set; }
        public double MagicResist { get; set; }
        public double FireResist { get; set; }
        public double LightningResist { get; set; }
        public double HolyResist { get; set; }
        public int Immunity { get; set; }
        public int Robustness { get; set; }
        public int Focus { get; set; }
        public int Vitality { get; set; }
        public int Poise { get; set; }
        public int Weight { get; set; }
        public ICollection<Build> Builds { get; set; } = new List<Build>();

    }
}
