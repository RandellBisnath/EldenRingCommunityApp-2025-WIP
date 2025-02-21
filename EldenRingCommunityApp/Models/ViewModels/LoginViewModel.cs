using System.ComponentModel.DataAnnotations;

namespace EldenRingCommunityApp.Models.ViewModels
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Enter Username")]
		public string Username { get; set; } = string.Empty;

		[Required(ErrorMessage = "Enter Password")]
		public string Password { get; set; } = string.Empty;
	}
}
