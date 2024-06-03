using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPLabb4.Models;

public class Customer
{
	public int Id { get; set; }

	[StringLength(30, MinimumLength = 1, ErrorMessage = "Name must be within 1 - 30 in length")]
	public string Name { get; set; }

	[StringLength(12, MinimumLength = 10, ErrorMessage = "Number must be within 10 - 12 in length")]
	public string Phone { get; set; }

	public string Email { get; set; }

	[DisplayName("Customer Books")]
	public ICollection<CustomerBook> CustomerBooks { get; set; } = [];
}
