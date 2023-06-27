using System.ComponentModel.DataAnnotations;

namespace SignalRNotify.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
        public string MessageType { get; set; }
        public DateTime NotificationDateTime { get; set; }
    }
}
