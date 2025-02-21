using EldenRingCommunityApp.Models.JoinTables;
using EldenRingCommunityApp.Models.SubClasses;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EldenRingCommunityApp.Models
{
    public class EldenRingAppContext : IdentityDbContext<User> 
    {
        public EldenRingAppContext(DbContextOptions<EldenRingAppContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; } = null;
        public DbSet<Tutorial> Tutorials { get; set; } = null;
        public DbSet<Message> Messages { get; set; } = null;
        public DbSet<Build> Builds { get; set; } = null;
        public DbSet<Helmet> Helmets { get; set; } = null;
        public DbSet<ChestArmor> ChestArmors { get; set; } = null;
        public DbSet<Gauntlets> Gauntlets { get; set; } = null;
        public DbSet<LegArmor> LegArmors { get; set; } = null;
        public DbSet<Spell> Spells { get; set; } = null;
        public DbSet<StartingClass> StartingClasses { get; set; } = null;
        public DbSet<Talisman> Talismans { get; set; } = null;
        public DbSet<Weapon> Weapons { get; set; } = null;
        public DbSet<BuildWeapon> BuildWeapons { get; set; } = null;
        public DbSet<BuildSpells> BuildSpells { get; set; } = null;
        public DbSet<BuildTalismans> BuildTalismans { get; set; } = null;
    
    }
}
