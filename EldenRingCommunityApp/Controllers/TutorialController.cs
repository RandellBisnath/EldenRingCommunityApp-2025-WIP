using EldenRingCommunityApp.Models;
using EldenRingCommunityApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text.RegularExpressions;

namespace EldenRingCommunityApp.Controllers
{
	public class TutorialController : Controller
	{
		private EldenRingAppContext context { get; set; }
		public TutorialController(EldenRingAppContext context)
		{
			this.context = context;
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(TutorialViewModel model)
		{
			if (ModelState.IsValid)
			{
				string youtubeVideoId = GetYouTubeVideoId(model.Uri);

				Console.WriteLine(youtubeVideoId);

				var tutorial = new Tutorial
				{
					Title = model.Title,
					Uri = new Uri(model.Uri),
					Description = model.Description,
					UserID = User.FindFirst(ClaimTypes.NameIdentifier).Value,
					YouTubeVideoId = youtubeVideoId
				};

				context.Tutorials.Add(tutorial);
				context.SaveChanges();

				return RedirectToAction("List", "Tutorial");
			}

			return View(model);
		}

		private string GetYouTubeVideoId(string youtubeUri)
		{
			string pattern = @"(?:https?:\/\/)?(?:www\.)?(?:youtube\.com\/(?:[^\/\n\s]+\/\S+\/|(?:v|e(?:mbed)?)\/|\S*?[?&]v=)|youtu\.be\/)([a-zA-Z0-9_-]{11})";
			Regex regex = new Regex(pattern);
			Match match = regex.Match(youtubeUri);

			if (match.Success)
			{
				return match.Groups[1].Value;
			}

			return null;
		}

		public IActionResult List()
		{
			var tutorials = context.Tutorials.OrderBy(
					  t => t.Title).ToList();
			return View(tutorials);
		}
	}
}
