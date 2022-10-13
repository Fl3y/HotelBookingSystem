using HotelBookingSystem;

namespace ComponentTests
{


    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PickRoom()
        {
            RoomSystem rs =  new RoomSystem();

            rs.PickRoom();
        }
    }
}