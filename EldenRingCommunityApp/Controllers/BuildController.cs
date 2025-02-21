using EldenRingCommunityApp.Models;
using EldenRingCommunityApp.Models.JoinTables;
using EldenRingCommunityApp.Models.SubClasses;
using EldenRingCommunityApp.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace EldenRingCommunityApp.Controllers
{
	public class BuildController : Controller
	{

		private EldenRingAppContext context { get; set; }
		public BuildController(EldenRingAppContext context)
		{
			this.context = context;
		}

		public BuildViewModel PopulateBVM(BuildViewModel bvm)
		{
			bvm.Helmets = context.Helmets.ToList();
			bvm.ChestArmors = context.ChestArmors.ToList();
			bvm.Gauntlets = context.Gauntlets.ToList();
			bvm.LegArmors = context.LegArmors.ToList();
			bvm.Weapons = context.Weapons.ToList();
			bvm.Spells = context.Spells.ToList();
			bvm.Talismans = context.Talismans.ToList();
			bvm.StartingClasses = context.StartingClasses.ToList();
			bvm.SelectedTalismans = new int[4];
			bvm.SelectedSpells = new int[12];
			bvm.SelectedWeapons = new int[4];
			bvm.Helmets = context.Helmets.ToList();
			bvm.Gauntlets = context.Gauntlets.ToList();
			bvm.ChestArmors = context.ChestArmors.ToList();
			bvm.LegArmors = context.LegArmors.ToList();
			return bvm;
		}

		[HttpGet]
		public IActionResult Create()
		{
			BuildViewModel bvm = new BuildViewModel();

			PopulateBVM(bvm);

			return View(bvm);
		}
		[HttpPost]
		public IActionResult Create(BuildViewModel bvm)
		{
			if (ModelState.IsValid)
			{
				int selectedStartingClass = bvm.SelectedStartingClass;
				int selectedHelmet = bvm.SelectedHelmet;
				int selectedGauntlets = bvm.SelectedGauntlets;
				int selectedChestArmor = bvm.SelectedChestArmor;
				int selectedLegArmor = bvm.SelectedLegArmor;
				int[] selectedTalismans = bvm.SelectedTalismans;
				int[] selectedSpells = bvm.SelectedSpells;
				int[] selectedWeapons = bvm.SelectedWeapons;

				Build myBuild = new Build();
				myBuild.Name = bvm.Name;
				myBuild.Vigor = bvm.Vigor;
				myBuild.Mind = bvm.Mind;
				myBuild.Endurance = bvm.Endurance;
				myBuild.Strength = bvm.Strength;
				myBuild.Dexterity = bvm.Dexterity;
				myBuild.Intelligence = bvm.Intelligence;
				myBuild.Faith = bvm.Faith;
				myBuild.Arcane = bvm.Arcane;
				myBuild.UserID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
				myBuild.StartingClassID = selectedStartingClass;
				myBuild.HelmetID = selectedHelmet;
				myBuild.GauntletsID = selectedGauntlets;
				myBuild.ChestArmorID = selectedChestArmor;
				myBuild.LegArmorID = selectedLegArmor;

				context.Builds.Add(myBuild);
				context.SaveChanges();

				Build latestBuild = context.Builds.OrderByDescending(id => id.BuildID).FirstOrDefault();

				foreach (int w in selectedWeapons)
				{
					BuildWeapon bw = new BuildWeapon();
					bw.BuildId = latestBuild.BuildID;
					bw.WeaponId = w;
					context.BuildWeapons.Add(bw);
				}
				foreach (int bs in selectedSpells)
				{
					BuildSpells buildSpells = new BuildSpells();
					buildSpells.BuildId = latestBuild.BuildID;
					buildSpells.SpellId = bs;
					context.BuildSpells.Add(buildSpells);
				}
				foreach(int bt in selectedTalismans)
				{
					BuildTalismans talismans= new BuildTalismans();
					talismans.BuildId = latestBuild.BuildID;
					talismans.TalismanId= bt;
					context.BuildTalismans.Add(talismans);
				}

				context.SaveChanges();


				return RedirectToAction("List");
			}
			else
			{
				return View(PopulateBVM(bvm));
			}
		}

		[HttpGet]
		public IActionResult List()
		{
			ListBuildViewModel builds = new ListBuildViewModel();
			builds.Builds = context.Builds.ToList();

			if (User.Identity.IsAuthenticated) {
				builds.CurrentUser = User.FindFirst(ClaimTypes.NameIdentifier).Value;
			}

			foreach (Build b in builds.Builds)
			{
				b.StartingClass = context.StartingClasses.Find(b.StartingClassID);
				b.BuildWeapons = context.BuildWeapons.Where(bw => bw.BuildId == b.BuildID).ToList();
				b.BuildTalismans = context.BuildTalismans.Where(bt => bt.BuildId == b.BuildID).ToList();
				b.BuildSpells = context.BuildSpells.Where(bs => bs.BuildId == b.BuildID).ToList();
			}
			return View(builds);
		}

		public IActionResult MyBuilds()
		{
			string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
			ListBuildViewModel builds = new ListBuildViewModel();
			builds.Builds = context.Builds.Where(b => b.UserID == userId).ToList();

			foreach (Build b in builds.Builds)
			{
				b.StartingClass = context.StartingClasses.Find(b.StartingClassID);
			}
			return View("List", builds);
		}

		[HttpGet]
		public IActionResult Delete(int id)
		{
			Build build = context.Builds.Find(id);
			return View(build);
		}

		[HttpPost]
		public IActionResult Delete(Build build)
		{

			foreach(BuildWeapon bw in context.BuildWeapons.Where(bw => build.BuildID == bw.BuildId))
			{
				context.BuildWeapons.Remove(bw);
			}
			foreach (BuildSpells bw in context.BuildSpells.Where(bw => build.BuildID == bw.BuildId))
			{
				context.BuildSpells.Remove(bw);
			}
			foreach (BuildTalismans bw in context.BuildTalismans.Where(bw => build.BuildID == bw.BuildId))
			{
				context.BuildTalismans.Remove(bw);
			}

			context.Builds.Remove(build);
			context.SaveChanges();
			return RedirectToAction("List");
		}

		[HttpGet]
		public IActionResult Update(int id) 
		{
			ViewBag.Action = "Update";
			Build build = context.Builds.Find(id);
			UpdateBuildViewModel ubvm = new UpdateBuildViewModel();
			
			PopulateBVM(ubvm);

			ubvm.BuildId= build.BuildID;
			ubvm.Name= build.Name;
			ubvm.SelectedStartingClass = build.StartingClass.StartingClassID;
			ubvm.Vigor = build.Vigor;
			ubvm.Mind = build.Mind;
			ubvm.Endurance= build.Endurance;
			ubvm.Strength= build.Strength;
			ubvm.Dexterity= build.Dexterity;
			ubvm.Intelligence= build.Intelligence;
			ubvm.Faith= build.Faith;
			ubvm.Arcane= build.Arcane;
			ubvm.SelectedChestArmor = build.ChestArmorID;
			ubvm.SelectedGauntlets= build.GauntletsID;
			ubvm.SelectedHelmet = build.HelmetID;
			ubvm.SelectedLegArmor= build.LegArmorID;

			List<BuildWeapon> weapons = context.BuildWeapons.Where(bw => bw.BuildId == build.BuildID).ToList();
			List<BuildTalismans> talismans = context.BuildTalismans.Where(bt => bt.BuildId == build.BuildID).ToList();
			List<BuildSpells> spells = context.BuildSpells.Where(bs => bs.BuildId == build.BuildID).ToList();

			int i = 0;

			foreach(BuildWeapon w in weapons)
			{
				ubvm.SelectedWeapons[i] = w.WeaponId;
				i++;
			}
			i = 0;
			foreach(BuildTalismans t in talismans)
			{
				ubvm.SelectedTalismans[i] = t.TalismanId; i++;
			}
			i = 0;
			foreach(BuildSpells spell in spells)
			{
				ubvm.SelectedSpells[i] = spell.SpellId;
				i++;
			}
			return View("Update", ubvm);
		}

		[HttpPost]
		public IActionResult Update(UpdateBuildViewModel ubvm)
		{
			if (ModelState.IsValid)
			{
				int selectedStartingClass = ubvm.SelectedStartingClass;
				int selectedHelmet = ubvm.SelectedHelmet;
				int selectedGauntlets = ubvm.SelectedGauntlets;
				int selectedChestArmor = ubvm.SelectedChestArmor;
				int selectedLegArmor = ubvm.SelectedLegArmor;
				int[] selectedTalismans = ubvm.SelectedTalismans;
				int[] selectedSpells = ubvm.SelectedSpells;
				int[] selectedWeapons = ubvm.SelectedWeapons;

				Build myBuild = new Build();
				myBuild.Name = ubvm.Name;
				myBuild.Vigor = ubvm.Vigor;
				myBuild.Mind = ubvm.Mind;
				myBuild.Endurance = ubvm.Endurance;
				myBuild.Strength = ubvm.Strength;
				myBuild.Dexterity = ubvm.Dexterity;
				myBuild.Intelligence = ubvm.Intelligence;
				myBuild.Faith = ubvm.Faith;
				myBuild.Arcane = ubvm.Arcane;
				myBuild.UserID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
				myBuild.StartingClassID = selectedStartingClass;
				myBuild.HelmetID = selectedHelmet;
				myBuild.GauntletsID = selectedGauntlets;
				myBuild.ChestArmorID = selectedChestArmor;
				myBuild.LegArmorID = selectedLegArmor;
				myBuild.BuildID = ubvm.BuildId;
				 
				context.Builds.Update(myBuild);
				context.SaveChanges();

				Build latestBuild = context.Builds.OrderByDescending(id => id.BuildID).FirstOrDefault();
				List<BuildWeapon> buildWeapons = context.BuildWeapons.Where(id => id.BuildId == latestBuild.BuildID).ToList();
				List<BuildSpells> buildSpells = context.BuildSpells.Where(id => id.BuildId == latestBuild.BuildID).ToList();
				List<BuildTalismans> buildTalismans = context.BuildTalismans.Where(id => id.BuildId == latestBuild.BuildID).ToList();

				int i = 0;
				foreach (BuildWeapon w in buildWeapons)
				{
					w.WeaponId = selectedWeapons[i];
					context.BuildWeapons.Update(w);
					i++;
				}
				i = 0;
				foreach (BuildTalismans t in buildTalismans)
				{
					t.TalismanId = selectedTalismans[i];
					context.BuildTalismans.Update(t);
					i++;
				}
				i = 0;
				foreach (BuildSpells s in buildSpells)
				{
					s.SpellId = selectedSpells[i];
					context.BuildSpells.Update(s);
					i++;
				}

				context.SaveChanges();


				return RedirectToAction("List");
			}
			else
			{
				return View(ubvm);
			}
		}

		[HttpGet]
		public IActionResult View(int id)
		{
			ViewBag.Action = "View";
			Build build = context.Builds.Find(id);
			UpdateBuildViewModel ubvm = new UpdateBuildViewModel();

			PopulateBVM(ubvm);

			ubvm.BuildId = build.BuildID;
			ubvm.Name = build.Name;
			ubvm.SelectedStartingClass = build.StartingClass.StartingClassID;
			ubvm.Vigor = build.Vigor;
			ubvm.Mind = build.Mind;
			ubvm.Endurance = build.Endurance;
			ubvm.Strength = build.Strength;
			ubvm.Dexterity = build.Dexterity;
			ubvm.Intelligence = build.Intelligence;
			ubvm.Faith = build.Faith;
			ubvm.Arcane = build.Arcane;
			ubvm.SelectedChestArmor = build.ChestArmorID;
			ubvm.SelectedGauntlets = build.GauntletsID;
			ubvm.SelectedHelmet = build.HelmetID;
			ubvm.SelectedLegArmor = build.LegArmorID;

			List<BuildWeapon> weapons = context.BuildWeapons.Where(bw => bw.BuildId == build.BuildID).ToList();
			List<BuildTalismans> talismans = context.BuildTalismans.Where(bt => bt.BuildId == build.BuildID).ToList();
			List<BuildSpells> spells = context.BuildSpells.Where(bs => bs.BuildId == build.BuildID).ToList();

			int i = 0;

			foreach (BuildWeapon w in weapons)
			{
				ubvm.SelectedWeapons[i] = w.WeaponId;
				i++;
			}
			i = 0;
			foreach (BuildTalismans t in talismans)
			{
				ubvm.SelectedTalismans[i] = t.TalismanId; i++;
			}
			i = 0;
			foreach (BuildSpells spell in spells)
			{
				ubvm.SelectedSpells[i] = spell.SpellId;
				i++;
			}
			return View("View", ubvm);
		}
	}
}
