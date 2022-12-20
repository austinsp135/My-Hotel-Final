using System.ComponentModel.DataAnnotations.Schema;

namespace MyHotel.Models
{
    public class Invoice
    {

        public int Id { get; set; }

        public ApplicationUser Customer { get; set; }
        [ForeignKey(nameof(Customer))]
        public string CustomerId { get; set; }

        public Room Rooms { get; set; }
        [ForeignKey(nameof(Rooms))]
        public int RoomId { get; set; }

        public Booking Booking { get; set; }
        [ForeignKey(nameof(Booking))]
        public int BookingId { get; set; }

        public Payment Payment { get; set; }
        [ForeignKey(nameof(Payment))]
        public int PaymentId { get; set; }


    }
}
