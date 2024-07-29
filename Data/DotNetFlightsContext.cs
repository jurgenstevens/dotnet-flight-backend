using DotNetFlights.Api.Entities;
using Microsoft.EntityFrameworkCore;


namespace DotNetFlights.Api.Data;
// used to map the entities into proper data
public class DotNetFlightsContext(DbContextOptions<DotNetFlightsContext> options) : DbContext(options)
{
  public DbSet<Flight> Flights => Set<Flight>();
  public DbSet<Meal> Meals => Set<Meal>();
  public DbSet<Ticket> Tickets => Set<Ticket>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    var decimalProps = modelBuilder.Model
    .GetEntityTypes()
    .SelectMany(t => t.GetProperties())
    .Where(p => (System.Nullable.GetUnderlyingType(p.ClrType) ?? p.ClrType) == typeof(decimal));

    foreach (var property in decimalProps)
    {
        property.SetPrecision(18);
        property.SetScale(2);
    }
  }
}
