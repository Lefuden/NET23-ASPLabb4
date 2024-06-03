using ASPLabb4.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPLabb4.Data;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{ }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<CustomerBook>().HasKey(cb => new { cb.CustomerId, cb.BookId });
		base.OnModelCreating(modelBuilder);
	}

	public DbSet<Customer> Customers { get; set; }
	public DbSet<Book> Books { get; set; }
	public DbSet<CustomerBook> CustomerBooks { get; set; }

}
