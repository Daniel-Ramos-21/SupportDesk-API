using System.ComponentModel.DataAnnotations;

namespace SupportDesk_API.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required, MaxLength(2000)]
        public string Message { get; set; } = string.Empty;

        public int TicketId { get; set; }
        public Ticket? Ticket { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.UtcNow;



    }
}
