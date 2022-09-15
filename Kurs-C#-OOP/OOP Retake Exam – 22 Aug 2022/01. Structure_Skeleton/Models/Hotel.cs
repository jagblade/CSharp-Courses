namespace BookingApp.Models
{
    using BookingApp.Models.Bookings.Contracts;
    using BookingApp.Models.Rooms.Contracts;
    using BookingApp.Repositories.Contracts;
    using Hotels.Contacts;
    using System;
    using Utilities.Messages;
    using Repositories;
    public class Hotel : IHotel
    {
        private string fullName;
        private int category;
        private double turnover;
        private RoomRepository rooms;
        private BookingRepository bookings;

        public Hotel(string fullName, int category)
        {
            FullName = fullName;
            Category = category;
            this.rooms = new RoomRepository();
            this.bookings = new BookingRepository();
        }

        public string FullName
        {
            get => this.fullName;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.HotelNameNullOrEmpty);
                }
                this.fullName = value;
            }
        }

        public int Category
        {
            get => this.category;

            private set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCategory);
                }
                this.category = value;
            }
        }

        public double Turnover
        {
            get => this.turnover;

            private set
            {
               this.turnover = TurnOverSum();
            }
        }


        IRepository<IRoom> IHotel.Rooms
        {
            get => (IRepository<IRoom>)this.rooms;
            set
            {
                rooms = (RoomRepository)value;
            }
        }
        IRepository<IBooking> IHotel.Bookings
        {
            get => (IRepository<IBooking>)bookings;
            set
            {
                bookings = (BookingRepository)value;
            }
        }

        private double TurnOverSum()
        {
            double sum = 0;
            foreach (var b in this.bookings.All())
            {
                sum += b.ResidenceDuration * b.Room.PricePerNight; 
            }

            return sum;
        }
    }
}
