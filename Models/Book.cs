using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPLabb4.Models;

public class Book
{
	public int Id { get; set; }

	[Required]
	[StringLength(50, MinimumLength = 1, ErrorMessage = "Title must be within 1 - 50 in length")]
	public string Title { get; set; }

	[DisplayName("Customer Books")]
	public ICollection<CustomerBook> CustomerBooks { get; set; } = [];
}
