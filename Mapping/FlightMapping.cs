using DotNetFlights.Api.Dtos;
using DotNetFlights.Api.Entities;

namespace DotNetFlights.Api.Mapping;

public static class FlightMapping
{
  public static Flight ToEntity(this CreateFlightDto flight)
  {
    return new Flight()
    {
      Airline = flight.Airline,
      Airport = flight.Airport,
      FlightNo = flight.FlightNo,
      Departs = flight.Departs,
      TicketId = flight.TicketId,
      MealId = flight.MealId,
    };
  }
}
