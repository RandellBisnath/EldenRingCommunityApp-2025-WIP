using EldenRingCommunityApp.Models.SubClasses;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using Newtonsoft.Json.Serialization;

namespace EldenRingCommunityApp.Models.ViewModels
{
	public class BuildViewModel
	{
		public string Name { get; set; }
		public int Vigor { get; set; }
		public int Mind { get; set; }
		public int Endurance { get; set; }
		public int Strength { get; set; }
		public int Dexterity { get; set; }
		public int Intelligence { get; set; }
		public int Faith { get; set; }
		public int Arcane { get; set; }

		[ValidateNever]
		public List<Helmet> Helmets { get; set; }
		public int SelectedHelmet { get; set; }

		[ValidateNever]
		public List<Gauntlets> Gauntlets { get; set; }
		public int SelectedGauntlets { get; set; }

		[ValidateNever]
		public List<ChestArmor> ChestArmors { get; set; }
		public int SelectedChestArmor { get; set; }

		[ValidateNever]
		public List<LegArmor> LegArmors { get; set;}
		public int SelectedLegArmor { get; set; }

		[ValidateNever]
		public List<Weapon> Weapons { get; set; }
		public int[] SelectedWeapons { get; set; }
		
		[ValidateNever]
		public List<Spell> Spells { get; set; }
		public int[] SelectedSpells { get; set; }

		[ValidateNever]
		public List<Talisman> Talismans { get; set; }
		public int[] SelectedTalismans { get; set; }

		[ValidateNever]
		public List<StartingClass> StartingClasses { get; set; }
		public int SelectedStartingClass { get; set; }
	}
}
