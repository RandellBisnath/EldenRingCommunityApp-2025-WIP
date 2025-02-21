using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EldenRingCommunityApp.Models
{
    public class User : IdentityUser
    {

        [NotMapped]
        public IList<string> RoleNames { get; set; } = null!;

        public ICollection<Tutorial> Tutorials { get; set; } = new List<Tutorial>();
        public ICollection<Message> Messages { get; set; } = new List<Message>();
        public ICollection<Build> Builds { get; set; } = new List<Build>();
    }
}
