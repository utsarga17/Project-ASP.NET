namespace RealEstateListing.Models
{
    public class Inquiry
    {
        public int InquiryId { get; set; }  // Primary Key
        public string Message { get; set; } // Inquiry Message
        public DateTime DateSent { get; set; } // Date Sent

        // Foreign Key linking this inquiry to a specific property
        public int PropertyId { get; set; }
        public RealEstate Property { get; set; }
    }




}
