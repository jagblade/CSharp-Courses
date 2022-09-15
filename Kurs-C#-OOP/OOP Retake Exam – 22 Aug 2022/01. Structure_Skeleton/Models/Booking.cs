namespace BookingApp.Models
{
    using BookingApp.Models.Rooms.Contracts;
    using Bookings.Contracts;
    using System;
    using System.Text;
    using Utilities.Messages;
    public class Booking : IBooking
    {
        private IRoom room;
        private int residenceDuration;
        private int adultCount;
        private int childCount;
        private int bookingNumber;

        public Booking(IRoom room, int residenceDuration, int adultsCount, int childrenCount, int bookingNumber)
        {
            this.room = room;
            this.residenceDuration = residenceDuration;
            this.adultCount = adultsCount;
            this.childCount = childrenCount;
            this.bookingNumber = bookingNumber;
        }

        public IRoom Room => this.room;

        public int ResidenceDuration {
            get => this.residenceDuration; 
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.DurationZeroOrLess);
                }
                this.residenceDuration = value;
            }
        }  

        public int AdultsCount 
        {
            get => this.adultCount;
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(ExceptionMessages.AdultsZeroOrLess);
                }
                this.adultCount = value;
            }
        }

        public int ChildrenCount
        {
            get => this.childCount;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.ChildrenNegative);
                }
                this.childCount = value;
            }
        }

        public int BookingNumber => this.bookingNumber;

        public string BookingSummary()
        {
            var sb = new StringBuilder();
            var total = Math.Round(this.residenceDuration * this.Room.PricePerNight, 2);
            sb.AppendLine($"Booking number: {this.BookingNumber}");
            sb.AppendLine($"Room type: {this.Room.GetType()}");
            sb.AppendLine($"Adults: {this.AdultsCount}");
            sb.AppendLine($"Children: {this.ChildrenCount}");
            sb.AppendLine($"Total amount paid: {total:F2}$");

            return sb.ToString().TrimEnd();
        }
    }
}
