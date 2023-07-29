namespace LearnedTry.Models
{
    public class Notification
    {
        public string Notification_Id { get; set; }
        public string Sender_Id { get; set; }
        public string Reciver_id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public bool Is_Read { get; set; }
        public string Type { get; set; }
        public DateTime Created_Date { get; set; }

    }
}
