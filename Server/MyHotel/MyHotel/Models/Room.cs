namespace MyHotel.Models
{

    public class Room
    {
        public int Id { get; set; }
        public string RoomNo { get; set; }
        public string FloorNo { get; set; }
        public string RoomType { get; set; }
        public string BedType { get; set; }

        public int RoomCount { get; set; } 
        public string RoomRate { get; set;}

        //public IEnumerable<Invoice> InvoiceDetails { get; set; }
    }
}
