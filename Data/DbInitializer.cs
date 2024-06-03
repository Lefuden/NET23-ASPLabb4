using ASPLabb4.Models;

namespace ASPLabb4.Data;

public class DbInitializer(ApplicationDbContext context)
{
	private readonly ApplicationDbContext _context = context;

	public async Task InitDb()
	{
		await _context.Database.EnsureCreatedAsync();
		if (_context.Customers.Any())
		{
			return;
		}

		await InitCustomers();
		await InitBooks();
		await InitCustomerBooks();
	}

	private async Task InitCustomers()
	{
		var customers = new List<Customer>
		{
			new()
			{
				Name = "Gogo Gorilla",
				Phone = "070123456789",
				Email = "gogo@gorilla.com"
			},
			new()
			{
				Name = "Curious George",
				Phone = "073123654789",
				Email = "george@curious.se"
			},
			new()
			{
				Name = "Ongobongo",
				Phone = "070987456321",
				Email = "ongo@bongo.com"
			},
			new()
			{
				Name = "Ape Apeson",
				Phone = "073741258963",
				Email = "ape@ape.com"
			},
			new()
			{
				Name = "Ora Orangutango",
				Phone = "070951784632",
				Email = "ora@monkey.com"
			}
		};

		foreach (var c in customers)
		{
			await _context.Customers.AddAsync(c);
		}
		await _context.SaveChangesAsync();
	}

	private async Task InitBooks()
	{
		var books = new List<Book>
		{
			new() { Title = "Do Androids Dream of Electric Sheep?" },
			new() { Title = "The Hitchhiker’s Guide to the Galaxy" },
			new() { Title = "Something Wicked This Way Comes" },
			new() { Title = "Pride and Prejudice and Zombies" },
			new() { Title = "The Hollow Chocolate Bunnies of the Apocalypse" },
			new() { Title = "I Was Told There'd Be Cake: Essays"},
			new() { Title = "I Have No Mouth & I Must Scream"},
			new() { Title = "No Country for Old Men"},
			new() { Title = "The Earth, My Butt, and Other Big Round Things"}
		};

		foreach (var b in books)
		{
			await _context.Books.AddAsync(b);
		}
		await _context.SaveChangesAsync();
	}

	private async Task InitCustomerBooks()
	{
		var customerBooks = new List<CustomerBook>
		{
			new()
			{
				CustomerId = 1,
				BookId = 1,
				DateBorrowed = RandomDateBorrowed(),
				DateReturned = default,
			},
			new()
			{
				CustomerId = 1,
				BookId = 3,
				DateBorrowed = RandomDateBorrowed(),
				DateReturned = default,
			},
			new()
			{
				CustomerId = 2,
				BookId = 2,
				DateBorrowed = RandomDateBorrowed(),
				DateReturned = DateTime.Now,
				IsReturned = true
			},
			new()
			{
				CustomerId = 3,
				BookId = 3,
				DateBorrowed = RandomDateBorrowed(),
				DateReturned = default,
			},
			new()
			{
				CustomerId = 3,
				BookId = 4,
				DateBorrowed = RandomDateBorrowed(),
				DateReturned = DateTime.Now,
				IsReturned = true
			},
			new()
			{
				CustomerId = 4,
				BookId = 4,
				DateBorrowed = RandomDateBorrowed(),
				DateReturned = DateTime.Now,
				IsReturned = true
			},
			new()
			{
				CustomerId = 5,
				BookId = 5,
				DateBorrowed = RandomDateBorrowed(),
				DateReturned = default,
			},
			new()
			{
				CustomerId = 5,
				BookId = 2,
				DateBorrowed = RandomDateBorrowed(),
				DateReturned = DateTime.Now,
				IsReturned = true
			},
			new()
			{
				CustomerId = 5,
				BookId = 1,
				DateBorrowed = RandomDateBorrowed(),
				DateReturned = default,
			}
		};

		foreach (var cB in customerBooks)
		{
			await _context.CustomerBooks.AddAsync(cB);
		}
		await _context.SaveChangesAsync();
	}

	private static DateTime RandomDateBorrowed()
	{
		Random rand = new();
		var randomBorrowDate = DateTime.Now.AddDays(-rand.Next(0, 30));
		return randomBorrowDate;
	}
}
