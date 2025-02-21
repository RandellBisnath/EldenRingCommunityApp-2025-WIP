using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace EldenRingCommunityApp.Models.ViewModels
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage = "Please Enter Username")]
		public string Username { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please Enter Password")]
		[DataType(DataType.Password)]
		[Compare("ConfirmPassword")]
		public string Password { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please Enter Email")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please confirm Password")]
		[DataType(DataType.Password)]
		[Display(Name = "Confirm Password")]
		public string ConfirmPassword { get; set; } = string.Empty;
	}
}
