<<<<<<< HEAD
﻿namespace Office_Seat_Booking_BLL.Services
{
    internal class ParkingService
    {
=======
﻿using Office_Seat_Booking_DLL.Repost;
using Office_Seat_Booking_Entity;
using Office_Seat_Booking_DLL.Repost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_BLL.Services
{
    public class ParkingService
    {
        IParkingRepost _parkingRepost;
        public ParkingService(IParkingRepost floorRepost)
        {
            _parkingRepost = floorRepost;
        }

        //Add Appointment
        public void AddParking(Parking Parking)
        {
            _parkingRepost.AddParking(Parking);
        }

        //Delete Appointment

        public void DeleteParking(int ParkingID)
        {
            _parkingRepost.DeleteParking(ParkingID);
        }

        //Update Appointment

        public void UpdateParking(Parking Parking)
        {
            _parkingRepost.UpdateParking(Parking);
        }

        //Get getAppointments

        public IEnumerable<Parking> GetParking()
        {
            return _parkingRepost.GetParkings();
        }
        public Parking GetByParkingId(int ParkingID)
        {
            return _parkingRepost.GetParkingById(ParkingID);
        }
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
    }
}
