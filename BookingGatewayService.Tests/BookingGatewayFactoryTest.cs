using BookingGatewayService.Tests.Fake;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingGatewayService.Tests
{
    
    public class BookingGatewayFactoryTest
    {
        [Test]
        public void CheckIsBookingGatewayImplemented()
        {
            Assert.IsNotNull(BookingGatewayFactory.CreateGateway(new FakeDBRepository()));
        }

        /// <summary>
        /// Create instance test
        /// </summary>
        [Test]
        public void CheckIsDBRepositorySetInBookingGateway()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);
            Assert.IsNotNull(gateway.DBRepository);
            Assert.AreEqual(fakeDB, gateway.DBRepository);
        }

        /// <summary>
        /// Create two instances test
        /// </summary>
        [Test]
        public void BookingGateway_CreateInstance_Test()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            var gateway2 = BookingGatewayFactory.CreateGateway(fakeDB);

            Assert.IsNotNull(gateway);
            Assert.IsNotNull(gateway2);
            Assert.AreNotEqual(gateway, gateway2);
            Assert.AreEqual(gateway.DBRepository, gateway2.DBRepository);
        }
    }
}
