namespace DotNetFlights.Api.Entities;

public class Flight
{
  public int FlightId { get; set; }
  public required string Airline { get; set;}
  public required string Airport { get; set;}
  public required int FlightNo { get; set;}
  public DateOnly Departs { get; set;}
  public required string Ticket { get; set;}
  public int MealId { get; set; }
  public Meal? Meals { get; set;}
}
