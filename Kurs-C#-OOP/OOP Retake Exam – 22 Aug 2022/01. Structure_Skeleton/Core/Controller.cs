namespace BookingApp.Core
{
    using Contracts;
    using Repositories;
    using Models;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Utilities.Messages;

    public class Controller : IController
    {
        private HotelRepository hotels;

        public Controller()
        {
            this.hotels = new HotelRepository();
        }

        public string AddHotel(string hotelName, int category)
        {
            Hotel nullHotel = null;
            if (hotels.Select(hotelName) == nullHotel)
            {
                return $"Hotel {hotelName} is already registered in our platform.";
            }
            hotels.AddNew(new Hotel(hotelName, category));
            return $"{category} stars hotel {hotelName} is registered in our platform and expects room availability to be uploaded.";
        }

        public string BookAvailableRoom(int adults, int children, int duration, int category)
        {
            throw new System.NotImplementedException();
        }

        public string HotelReport(string hotelName)
        {
            throw new System.NotImplementedException();
        }

        public string SetRoomPrices(string hotelName, string roomTypeName, double price)
        {
          

            if (hotels.All().Any(x => x.FullName == hotelName))
            {
                return $"Profile {hotelName} doesn’t exist!";
            }
            if (string.IsNullOrEmpty(roomTypeName))
            {
                throw new ArgumentException(ExceptionMessages.RoomTypeIncorrect);
            }
            if (!(hotels.All().Any(x => x.GetType().ToString() == roomTypeName)))
            {
                return "Room type is not created yet!";
            }
            if (hotels.All().Any(x => x.Turnover > 0))
            {
                throw new InvalidOperationException(ExceptionMessages.PriceAlreadySet);   
            }

            return OutputMessages.PriceSetSuccessfully;
        }

        public string UploadRoomTypes(string hotelName, string roomTypeName)
        {
            Hotel nullHotel = null;
             var exist = hotels.All().Any(x => x.GetType().Name == roomTypeName);
     
            if ((hotels.Select(hotelName) == nullHotel))
            {
                return $"Profile {hotelName} doesn’t exist!";
            }

            if (exist)
            {
                return "Room type is already created!";
            }
            if (string.IsNullOrEmpty(roomTypeName))
            {
                throw new ArgumentException(ExceptionMessages.RoomTypeIncorrect);
            }
            Type t = roomTypeName.GetType();
            var room = Activator.CreateInstance(t);

            return OutputMessages.RoomTypeAdded;
        }
    }
}
