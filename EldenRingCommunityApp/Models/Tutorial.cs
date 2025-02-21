namespace EldenRingCommunityApp.Models
{
    public class Tutorial
    {
        public int TutorialID { get; set; }
        public string Title { get; set; }
        public virtual Uri Uri { get; set; }
        public string Description { get; set; }
        public string UserID { get; set; }
        public User User { get; set; }
		public string YouTubeVideoId { get; set; }
	}
}
