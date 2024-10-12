using RealEstateListing.Models;

public class RealEstate
{
    public int PropertyId { get; set; }  // Primary Key
    public string Name { get; set; }      // Property Name
    public decimal Price { get; set; }    // Property Price
    public string Location { get; set; }  // Property Location
    public string Description { get; set; }  // Property Description

    // Navigation property: One RealEstate can have many Inquiries
    public ICollection<Inquiry> Inquiries { get; set; }
}

