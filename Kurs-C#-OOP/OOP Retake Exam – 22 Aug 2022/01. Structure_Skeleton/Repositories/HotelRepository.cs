namespace BookingApp.Repositories
{
    using Contracts;
    using Models;
    using System.Collections.Generic;

    public class HotelRepository : IRepository<Hotel>
    {
        private IRepository<Hotel> hotelRepository;
        public HotelRepository()
        {
            this.hotelRepository = new HotelRepository();
        }
        public void AddNew(Hotel model)
        {
            hotelRepository.AddNew(model);
        }

        public IReadOnlyCollection<Hotel> All()
        {
            return (IReadOnlyCollection<Hotel>)hotelRepository;
        }

        public Hotel Select(string criteria)
        {
            return hotelRepository.Select(criteria);
        }
    }
}
