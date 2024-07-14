namespace DotNetFlights.Api;

public class Ticket
{
  public string TicketId { get; set;}
  public required string Seat { get; set;}
  public required decimal Price { get; set;}
}
