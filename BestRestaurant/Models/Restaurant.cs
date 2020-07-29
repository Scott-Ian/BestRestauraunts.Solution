namespace BestRestaurants.Models
{
  public class Restaurant
  { 
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public int PriceScale { get; set; }
    public int Rating { get; set; }
    public string Description { get; set; }
    public string Atmosphere { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine {get; set; }
  }
}
