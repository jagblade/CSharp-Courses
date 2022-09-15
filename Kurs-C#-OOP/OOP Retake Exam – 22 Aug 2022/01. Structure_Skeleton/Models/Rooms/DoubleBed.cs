namespace BookingApp.Models.Rooms
{
    internal class DoubleBed : Room
    {
        private const int doubleBedRoomCapacity = 2;
        public DoubleBed():base(doubleBedRoomCapacity)
        {

        }
    }
}
