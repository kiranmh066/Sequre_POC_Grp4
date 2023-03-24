<<<<<<< HEAD
﻿namespace Office_Seat_Booking_BLL.Services
{
    internal class FloorService
    {
=======
﻿using Office_Seat_Booking_DLL.Repost;
using Office_Seat_Booking_Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_BLL.Services
{
    public class FloorService
    {
        IFloorRepost _floorRepost;
        public FloorService(IFloorRepost floorRepost)
        {
            _floorRepost = floorRepost;
        }

        //Add Appointment
        public void AddFloor(Floor floor)
        {
            _floorRepost.AddFloor(floor);
        }

        //Delete Appointment

        public void DeleteFloor(int floorID)
        {
            _floorRepost.DeleteFloor(floorID);
        }

        //Update Appointment

        public void UpdateFloor(Floor floor)
        {
            _floorRepost.UpdateFloor(floor);
        }

        //Get getAppointments

        public IEnumerable<Floor> GetFloor()
        {
            return _floorRepost.GetFloors();
        }
        public Floor GetByFloorId(int EmployeeID)
        {
            return _floorRepost.GetFloorById(EmployeeID);
        }
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
    }
}
