using FrontDeskApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BookigApp.Tests
{
    public class Tests
    {
        private Room testRoomOne;
        private Hotel newHotel;
        private Booking testBooking;

        [SetUp]
        public void Setup()
        {
            this.testRoomOne = new Room(2, 100);
            var testRoomTwo = new Room(3, 150);
            this.newHotel = new Hotel("Tested", 3);
            this.testBooking = new Booking(3, testRoomTwo, 4);
        }

        [Test]
        public void RoomBedCapacity_ShoudThrowExeptionIfNullOrLess()
        {
            Assert.Throws<ArgumentException>(() =>
            {

                var room = new Room(-1, 50);
            }
           );
        }

        [Test]

        public void RoomPricePerNight_ShoudThrowExeptionIfNullOrLess()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var room = new Room(2, -10);
            });
        }

        [Test]
        public void RoomConstructorShouldInitCorrectly()
        {
            int expectedBedCapacity = 2;
            double expectedpricePerNight = 100;

            var room = new Room(expectedBedCapacity, expectedpricePerNight);

            int actualBedCapacity = room.BedCapacity;
            double actualpricePerNight = room.PricePerNight;

            Assert.AreEqual(expectedBedCapacity, actualBedCapacity);
            Assert.AreEqual(expectedpricePerNight, actualpricePerNight);
        }

        [Test]
        public void BookingConstructor_ShouldInitCorrectly()
        {
            int expectedBookingNumber = 12;
            Room expectedRoom = new Room(2, 100);
            int expectedDuratation = 4;

            var book = new Booking(expectedBookingNumber, expectedRoom, expectedDuratation);

            int actualBookingNumber = book.BookingNumber;
            var actualRoom = book.Room;
            int actualDuratation = book.ResidenceDuration;

            Assert.AreEqual(expectedBookingNumber, actualBookingNumber);
            Assert.AreEqual(expectedRoom, actualRoom);
            Assert.AreEqual(expectedDuratation, actualDuratation);
        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase(" ")]

        public void HotelFullName_ShouldThrowExeptionIfNullOrWhitespace(string name)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var hotel = new Hotel(name, 3);
            });
        }

        [Test]
        public void HotelFullName_ShouldReturnCorrectly()
        {
            string ExpectedName = "Test";

            var hotel = new Hotel(ExpectedName, 3);

            Assert.That(hotel.FullName, Is.EqualTo(ExpectedName));

        }
        [Test]
        public void HotelCategory_ShouldREturnCorrectly()
        {
            int expectedCategory = 3;
            var hotel = new Hotel("test", expectedCategory);
            Assert.That(hotel.Category, Is.EqualTo(expectedCategory));
        }

        [TestCase(0)]
        [TestCase(6)]
        public void HotelCategory_ShouldThrowArgumentExeption(int category)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var hotel = new Hotel("Test", category);
            });
        }

        [Test]

        public void HotelTurnover_ShouldReturnZero()
        {
            var expectedTurnOver = 0;
            var hotel = new Hotel("test", 3);

            var actualTurnOver = hotel.Turnover;

            Assert.AreEqual(expectedTurnOver, actualTurnOver);

        }

        [Test]
        public void HotelRooms_ShouldReturnIReadOnlyCollection()
        {
        var expectedCollection = newHotel.Rooms;

        
         
        Assert.True(expectedCollection is IReadOnlyCollection<Room>);
        }

        [Test]
        public void HotelBookings_ShouldReturnIReadOnlyCollection()
        {
            var expectedCollection = newHotel.Bookings;

            Assert.True(expectedCollection is IReadOnlyCollection<Booking>);
        }

        [Test]

        public void HotelAddRoom_ShouldAddRoomCorrectly()
        {
            var newRoom = new Room(4, 200);
            var expectedCount = newHotel.Rooms.Count + 1;
            newHotel.AddRoom(newRoom);
            Assert.AreEqual(expectedCount, newHotel.Rooms.Count);
        }

        [TestCase(0)]
        [TestCase(-2)]
        public void HotelBookRoom_ShouldThrowExeptionWhenAdultsAreZeroOrLess(int adults)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                newHotel.BookRoom(adults, 1, 2, 500);
            });
        }

        [Test]
        public void HotelBookRoom_ShouldThrowExeptionWhenChildrenAreLessThenZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                newHotel.BookRoom(1, -1, 2, 500);
            });
        }

        [Test]
        public void HotelBookRoom_ShouldThrowExeptionWhenDurationIsLessThenZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                newHotel.BookRoom(1, 0, -2, 500);
            });
        }

        [Test]
        public void HotelBookRoom_ShouldAddBookingWhenRoomAvaliable()
        {
            var newHotel = new Hotel("BookHotel", 2);
            newHotel.AddRoom(testRoomOne);
            var expectedBookings = 1 ;

            newHotel.BookRoom(1, 0, 2, 600);
            var actualBookings = newHotel.Bookings.Count;

            Assert.AreEqual(expectedBookings, actualBookings);
        }

        [Test]
        public void HotelBookRoom_ShouldChangeTurnOverCorrectly()
        {
            var newHotel = new Hotel("BookHotel", 2);
            newHotel.AddRoom(testRoomOne);
            var expectedTurnover = testRoomOne.PricePerNight*3;
            newHotel.BookRoom(1, 0, 3, 300);
            var actualTurnover = newHotel.Turnover;

            Assert.AreEqual(expectedTurnover, actualTurnover);
        }
    }
}
