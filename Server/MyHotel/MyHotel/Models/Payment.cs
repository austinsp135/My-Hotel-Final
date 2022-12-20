using System.ComponentModel.DataAnnotations.Schema;

namespace MyHotel.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public ApplicationUser Customer { get; set; }
        [ForeignKey(nameof(Customer))]
        public string CustomerId { get; set; }

        public Room Rooms { get; set; }
        [ForeignKey(nameof(Rooms))]
        public int RoomId { get; set; }
        public int Amount { get; set; }
        public string CardHolder { get; set; }
        public CardType CardType { get; set; }
        public string CardNumber { get; set; }

        public string ExpiryDate { get; set; }
        public string CVV { get; set; }

        public IEnumerable<Invoice> PaymentInvoice { get; set; }
    }
}
