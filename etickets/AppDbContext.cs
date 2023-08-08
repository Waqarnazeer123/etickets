using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

public class AppDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}