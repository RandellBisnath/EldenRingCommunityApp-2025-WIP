using EldenRingCommunityApp.Models.SubClasses;

namespace EldenRingCommunityApp.Models.JoinTables
{
	public class BuildTalismans
	{
		public int BuildTalismansId { get; set; }
		public int BuildId { get; set; }
		public int TalismanId { get; set; }
		public Talisman Talisman { get; set; }
		public Build Build { get; set; }
	}
}
