using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPLabb4.Models;

public class CustomerBook
{
	public int CustomerId { get; set; }
	public Customer Customer { get; set; }
	public int BookId { get; set; }
	public Book Book { get; set; }

	[Required]
	[DisplayName("Date Borrowed")]
	public DateTime DateBorrowed { get; set; } = DateTime.Now;
	[DisplayName("Date Returned")]
	public DateTime DateReturned { get; set; }
	public bool IsReturned { get; set; } = false;
}
