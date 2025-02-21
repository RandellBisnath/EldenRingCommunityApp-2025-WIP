namespace EldenRingCommunityApp.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageSendDate { get; set; }
        public string UserID { get; set; }
        public User User { get; set; }
    }
}
