namespace BookingApp.Models.Rooms
{
    internal class Apartment : Room
    {
        private const int apartmentBedCapacity = 6;
        public Apartment() : base(apartmentBedCapacity)
        {
        }
    }
}
