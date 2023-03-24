<<<<<<< HEAD
﻿namespace Office_Seat_Booking_BLL.Services
{
    internal class SeatService
    {
=======
﻿
using Office_Seat_Booking_DLL.Repost;
using Office_Seat_Booking_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_BLL.Services
{
    public class SeatService
    {
        ISeatRepost _SeatRepost;
        public SeatService(ISeatRepost seatRepost)
        {
            _SeatRepost = seatRepost;
        }

        //Add Appointment
        public void AddSeat(Seat seat)
        {
            _SeatRepost.AddSeat(seat);
        }

        //Delete Appointment


        public void DeleteSeat(int seatID)
        {
            _SeatRepost.DeleteSeat(seatID);
        }

        //Update Appointment

        public void UpdateSeat(Seat Seat)
        {
            _SeatRepost.UpdateSeat(Seat);
        }

        //Get getAppointments

        public IEnumerable<Seat> GetSeat()
        {
            return _SeatRepost.GetSeats();
        }
        public Seat GetBySeatId(int SeatID)
        {
            return _SeatRepost.GetSeatById(SeatID);
        }
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
    }
}
