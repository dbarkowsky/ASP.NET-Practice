using Microsoft.EntityFrameworkCore;

namespace ASPNET_PRACTICE.Models;

public class ActorContext : DbContext
{
    public ActorContext(DbContextOptions<ActorContext> options)
        : base(options)
    {
    }

    public DbSet<Actor> Actors { get; set; } = null!;
}