using Microsoft.EntityFrameworkCore;
using MuseumTours.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumTours.Domain
{
	public class MuseumToursContext : DbContext
	{
        public MuseumToursContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
		public DbSet<Excursion> Excursions { get; set; }

	}
}
 