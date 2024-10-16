namespace gregslist_csharp.Models;

public class House
{
  public int Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }

  public uint Sqft { get; set; }
  public uint Bedrooms { get; set; }
  public double Bathrooms { get; set; }
  public string ImgUrl { get; set; }
  public string Description { get; set; }
  public uint Price { get; set; }
  // public string CreatorId { get; set; }
  // public Account Creator { get; set; }
}