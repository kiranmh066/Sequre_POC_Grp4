<<<<<<< HEAD
﻿using Office_Seat_Booking_Entity;

namespace Office_Seat_Booking_DLL
{
    public class OfficeDbContext : DbContext
=======
﻿using Microsoft.EntityFrameworkCore;
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
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
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
<<<<<<< HEAD
        public DbSet<Parking> parking { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=DESKTOP-2EN1VVU\\SQLEXPRESS; Initial Catalog = SeatBooking; Integrated Security=True;");
=======

        public DbSet<Parking> parking { get; set; }

       

       
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source = DESKTOP-2JIKDUR\\SQLEXPRESS; Initial Catalog = OfficeDb; Integrated Security = True; Trusted_Connection=True; TrustServerCertificate=True;");
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f

        }
    }
}
