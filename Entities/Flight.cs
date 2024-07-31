namespace DotNetFlights.Api.Entities;

public class Flight
{
  public int FlightId { get; set; }
  public required string Airline { get; set;}
  public required string Airport { get; set;}
  public required int FlightNo { get; set;}
  public DateOnly Departs { get; set;}
  public ICollection<Ticket>? Ticket { get; }  = new List<Ticket>(); // Collection navigation containing dependents
  public int MealId { get; set; }
  public Meal? Meals { get; set;}
}
