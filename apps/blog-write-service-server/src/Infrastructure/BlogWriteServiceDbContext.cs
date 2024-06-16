using Microsoft.EntityFrameworkCore;

namespace BlogWriteService.Infrastructure;

public class BlogWriteServiceDbContext : DbContext
{
    public BlogWriteServiceDbContext(DbContextOptions<BlogWriteServiceDbContext> options)
        : base(options) { }
}
