using Microsoft.EntityFrameworkCore;
using Office_Seat_floor_DLL;
using Office_Seat_floor_DLL.Repost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_floor_DLL.Repost
{
    public class FloorRepost:IFloorRepost
    {
        OfficeDbContext _dbContext;//default private

        public FloorRepost(OfficeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Addfloor(Floor floor)
        {
            _dbContext.floor.Add(floor);
            _dbContext.SaveChanges();
        }

        public void Deletefloor(int floorId)
        {
            var floor = _dbContext.floor.Find(floorId);
            _dbContext.floor.Remove(floor);
            _dbContext.SaveChanges();
        }

        public floor GetfloorById(int floorId)
        {
            return _dbContext.floor.Find(floorId);
        }

        public IEnumerable<floor> Getfloors()
        {
            return _dbContext.floor.ToList();
        }


        public void Updatefloor(floor floor)
        {

            _dbContext.Entry(floor).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
