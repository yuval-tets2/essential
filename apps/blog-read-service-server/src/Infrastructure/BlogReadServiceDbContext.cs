using Microsoft.EntityFrameworkCore;

namespace BlogReadService.Infrastructure;

public class BlogReadServiceDbContext : DbContext
{
    public BlogReadServiceDbContext(DbContextOptions<BlogReadServiceDbContext> options)
        : base(options) { }
}
