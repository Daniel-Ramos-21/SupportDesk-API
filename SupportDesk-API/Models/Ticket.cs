using System.ComponentModel.DataAnnotations;

namespace SupportDesk_API.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Title { get; set; } = string.Empty;

        [Required, MaxLength(2000)]
        public string Description { get; set; } = string.Empty;

        public TicketStatus status { get; set; } = TicketStatus.Open;
        public TicketPriority priority { get; set; } = TicketPriority.Medium;

        public int CategoryId { get; set; }
        public Category? Category { get; set; }


        public int CreatedyById { get; set;  }
        public User? CreatedBy { get; set; }


        public int? AssignedToId { get; set; }
        public User? AssignedTo { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateAt { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();




    }
}
