using Microsoft.AspNetCore.Mvc;
using MuseumTours.Domain;
using MuseumTours.Dto.Clients;
using System.Security.Cryptography.X509Certificates;

namespace MuseumTours.Controllers
{
    public class ClientsController : Controller
    {
        private readonly MuseumToursContext _context;

        public ClientsController(MuseumToursContext context)
        {
            _context = context;
        }

        public IActionResult GetAll()
        {
            var clients = _context.Clients.ToList();
            var result = new List<ClientTabelDto>();

            foreach (var client in clients)
            {
                //var clientTableDto = new ClientTabelDto {
                //    LastName = client.FirstName,
                //    FirstName = client.LastName,
                //    FatherName = client.FatherName,
                //    Organization = client.Organization,
                //    Mail = client.Mail,
                //    Telephone = client.Telephone,
                //    TourName = client.TourName,
                //    NumberOfPersons = client.NumberOfPersons,
                //    ApplicationStatus = client.ApplicationStatus,
                //    AdditionalInformationt = client.AdditionalInformationt
                //};
                result.Add(ClientTabelDto);
            }
            
            return Ok(result);
        }
        public IActionResult Index(int id) 
        {
            return View();
        }
    }
}
