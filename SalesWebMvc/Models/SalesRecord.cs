namespace SalesWebMvc.Models
{
	public class SalesRecord
	{
		public int Id { get; set; }
		public DateTime SalesDate { get; set; }	
		public decimal Amount { get; set; }
		public int Status { get; set; }
	}
}
