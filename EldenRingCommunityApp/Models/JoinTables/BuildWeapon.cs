using EldenRingCommunityApp.Models.SubClasses;

namespace EldenRingCommunityApp.Models.JoinTables
{
	public class BuildWeapon
	{
		public int BuildWeaponId { get; set; }
		public int BuildId { get; set; }
		public int WeaponId { get; set; }
		public Weapon Weapon { get; set; }
		public Build Build { get; set; }
	}
}
