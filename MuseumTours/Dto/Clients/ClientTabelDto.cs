namespace MuseumTours.Dto.Clients
{
    public abstract class ClientTabelDto : EntityDto
    {
        public DateTime DateTime { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string Organization { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public string TourName { get; set; }
        public int NumberOfPersons { get; set; }
        public string ApplicationStatus { get; set; }
        public string AdditionalInformation { get; set; }
    }
}
