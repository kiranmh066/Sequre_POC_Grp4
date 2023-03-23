using Office_Seat_Booking_DLL;
using Office_Seat_Booking_DLL.Repost;

namespace Office_Seat_Floor_DLL.Repost
{
    public class FloorRepost : IFloorRepost
    {
        OfficeDbContext _dbContext;//default private

        public FloorRepost(OfficeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddFloor(Floor floor)
        {
            _dbContext.floor.Add(floor);
            _dbContext.SaveChanges();
        }

        public void DeleteFloor(int floorId)
        {
            var floor = _dbContext.floor.Find(floorId);
            _dbContext.floor.Remove(floor);
            _dbContext.SaveChanges();
        }

        public Floor GetFloorById(int floorId)
        {
            return _dbContext.floor.Find(floorId);
        }

        public IEnumerable<Floor> GetFloors()
        {
            return _dbContext.floor.ToList();
        }


        public void UpdateFloor(Floor floor)
        {

            _dbContext.Entry(floor).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
