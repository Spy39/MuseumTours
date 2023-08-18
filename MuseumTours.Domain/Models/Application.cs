using System.ComponentModel.DataAnnotations.Schema;

namespace MuseumTours.Domain.Models
{
    public class Application : Entity
    {
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public int ExcursionId { get; set; }
        [ForeignKey("ExcursionId")]
        public Client Client { get; set; }
        public Excursion Excursion { get; set; }
        public int NumberOfPersons { get; set; }
        public string ApplicationStatus { get; set; }
    }
}