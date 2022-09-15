
namespace BookingApp.Repositories
{
    using BookingApp.Models;
    using BookingApp.Repositories.Contracts;
    using System.Collections.Generic;

    public class RoomRepository : IRepository<Room>
    {
        private readonly IRepository<Room> roomRepository;
        public RoomRepository()
        {
            roomRepository = new RoomRepository();
        }

        void IRepository<Room>.AddNew(Room model)
        {
            roomRepository.AddNew(model);
        }

        IReadOnlyCollection<Room> IRepository<Room>.All()
        {
            return (IReadOnlyCollection<Room>)roomRepository;
        }

        Room IRepository<Room>.Select(string criteria)
        {
            return roomRepository.Select(criteria);
        }
    }
}
