using DotNetFlights.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotNetFlights.Api.Data;
// used to map the entities into proper data
public class DotNetFlightsContext(DbContextOptions<DotNetFlightsContext> options) : DbContext(options)
{
  public DbSet<Flight> Flights => Set<Flight>();
  public DbSet<Meal> Meals => Set<Meal>();
  public DbSet<Ticket> Tickets => Set<Ticket>();
}
