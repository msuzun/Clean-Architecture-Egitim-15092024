using Microsoft.EntityFrameworkCore;

namespace CleanArchitecute.Persistance.Context;

public sealed class AppDbContext : DbContext
{
    //AppDbContext context = new();
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    base.OnConfiguring(optionsBuilder);
    //}

    private readonly AppDbContext _context;
    public AppDbContext(AppDbContext context)
    {
        _context = context;
    }
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}
