namespace WebAppDETAug2022.Models
{
	public class Tickets
	{
		public string Name { get; set; }

		public int Price { get; set; }

		public int Id { get; set; }

		internal static Tickets? FirstOrDefault(Func<object, bool> value)
		{
			throw new NotImplementedException();
		}
	}
}
