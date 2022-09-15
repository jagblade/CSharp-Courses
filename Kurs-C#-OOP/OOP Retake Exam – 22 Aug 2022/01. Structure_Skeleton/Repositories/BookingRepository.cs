
namespace BookingApp.Repositories
{
    using BookingApp.Models;
    using BookingApp.Repositories.Contracts;
    using System.Collections.Generic;

    public class BookingRepository : IRepository<Booking>
    {
        private readonly IRepository<Booking> bookingRepository;
        public BookingRepository()
        {
            this.bookingRepository = new BookingRepository();
        }
        public void AddNew(Booking model)
        {
            bookingRepository.AddNew(model);
        }

        public IReadOnlyCollection<Booking> All()
        {
            return (IReadOnlyCollection<Booking>)bookingRepository;
        }

        public Booking Select(string criteria)
        {
            return bookingRepository.Select(criteria);
        }
    }
}
