namespace SalesWebMvc.Models
{
	public class Seller
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Email { get; set; }

		
		public DateTime Birthday { get; set; }
		public decimal BaseSalary { get; set; }
	}
}
