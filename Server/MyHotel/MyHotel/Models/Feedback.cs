using System.ComponentModel.DataAnnotations.Schema;

namespace MyHotel.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        public ApplicationUser Customer { get; set; }
        [ForeignKey(nameof(Customer))]
        public string CustomerId { get; set; }

        public Room Rooms { get; set; }
        [ForeignKey(nameof(Rooms))]
        public int RoomId { get; set; }

        public String Description { get; set; }

    }
}
