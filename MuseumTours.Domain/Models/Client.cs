namespace MuseumTours.Domain.Models
{
	public class Client : Entity
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string FatherName { get; set; }
		public string Organization { get; set; }
		public string Telephone { get; set; }
		public string Mail { get; set; }
		public string AdditionalInformation { get; set; }
	}
}
