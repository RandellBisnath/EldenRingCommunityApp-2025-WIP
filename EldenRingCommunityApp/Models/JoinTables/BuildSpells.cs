using EldenRingCommunityApp.Models.SubClasses;

namespace EldenRingCommunityApp.Models.JoinTables
{
	public class BuildSpells
	{
		public int BuildSpellsId { get; set; }
		public int BuildId { get; set; }
		public int SpellId { get; set; }
		public Spell Spell { get; set; }
		public Build Build { get; set; }
	}
}
