using System.ComponentModel.DataAnnotations;

namespace SignalRNotify.Models
{
    public class HubConnection
    {
        [Key]
        public int Id { get; set; }
        public string ConnectionId { get; set; }
        public string Username { get; set; }
    }
}
