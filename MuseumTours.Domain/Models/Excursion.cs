using System.ComponentModel.DataAnnotations.Schema;

namespace MuseumTours.Domain.Models
{
	public class Excursion : Entity
	{
		public DateTime DateTime { get; set; }
		public string TourName { get; set; }
	}
}
