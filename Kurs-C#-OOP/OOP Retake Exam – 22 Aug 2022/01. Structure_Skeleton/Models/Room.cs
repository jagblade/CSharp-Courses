
namespace BookingApp.Models
{
    using BookingApp.Models.Rooms.Contracts;
    using System;
    using Utilities.Messages;
    public abstract class Room : IRoom
    {
        private double pricePerNight;
        private int bedCapacity;

        public Room(int bedCapacity)
        {
            this.bedCapacity = bedCapacity;
        }
        public int BedCapacity { get; }
        public double PricePerNight
        {
            get => this.pricePerNight;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.PricePerNightNegative);
                }
                this.pricePerNight = value;
            }
        }
           

        public void SetPrice(double price) => this.pricePerNight = price;
    }
}
