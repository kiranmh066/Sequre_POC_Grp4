using Microsoft.EntityFrameworkCore;
using Office_Seat_Booking_Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_DLL
{
    public class OfficeDbContext: DbContext
    {
        public OfficeDbContext()
        {
        }
        public OfficeDbContext(DbContextOptions<OfficeDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> employee { get; set; }
        public DbSet<Booking> booking { get; set; }
        public DbSet<Floor> floor { get; set; }
        public DbSet<Seat> seat { get; set; }

        public DbSet<Parking> parking { get; set; }

       

       
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source = DESKTOP-2JIKDUR\\SQLEXPRESS; Initial Catalog = OfficeDb; Integrated Security = True; Trusted_Connection=True; TrustServerCertificate=True;");

        }
    }
}
