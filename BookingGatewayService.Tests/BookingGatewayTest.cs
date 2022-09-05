using BookingGatewayService.Exceptions;
using BookingGatewayService.Tests.Fake;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingGatewayService.Tests
{
    
    public class BookingGatewayTest
    {

        #region StartBooking-tests

        /// <summary>
        /// Check is StartBooking implemented
        /// </summary>
        [Timeout(5000)]
        [Test]
        [NonParallelizable]
        public void StartBookingImplementationTest()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);
            gateway.StartBooking();
            gateway.EndBooking();
        }

        /// <summary>
        /// Calling the method by the same thread (again before EndBooking) in the same time should throw BookingInProgressException.
        /// </summary>
        [Timeout(5000)]
        [Test]
        [NonParallelizable]
        public void StartBooking_StartAgainByTheSameThread()
        {
            var DB = new FakeDBRepository();

            var gateway = BookingGatewayFactory.CreateGateway(DB);
            Assert.IsNotNull(gateway);

            gateway.StartBooking();
            try
            {
                Assert.Throws<BookingInProgressException>(() => gateway.StartBooking());
            }
            finally
            {
                gateway.EndBooking();
            }
        }

        /// <summary>
        /// Calling the method by the same thread (again before EndBooking) in the same time should throw BookingInProgressException.
        /// </summary>
        [Timeout(5000)]
        [Test]
        [NonParallelizable]
        public void StartBooking_StartAgainAfterStop()
        {
            var DB = new FakeDBRepository();

            var gateway = BookingGatewayFactory.CreateGateway(DB);
            Assert.IsNotNull(gateway);

            gateway.StartBooking();
            gateway.EndBooking();
            gateway.StartBooking();
            try
            {
                Assert.Throws<BookingInProgressException>(() => gateway.StartBooking()); // try start again...
            }
            finally
            {
                gateway.EndBooking();
            }
        }

        /// <summary>
        /// Calling IBookingGateway.StartBooking starts booking process. 
        /// Calling the method by other thread or the same thread (again before EndBooking) in the same time should throw BookingInProgressException.
        /// </summary>
        [Timeout(5000)]
        [Test]
        [NonParallelizable]
        public void StartBooking_WhenOtherCall_StartBooking_OtherThread_Test()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            var gatewayForThread1 = BookingGatewayFactory.CreateGateway(fakeDB);

            Assert.IsNotNull(gateway);
            Assert.IsNotNull(gatewayForThread1);

            // main thread starts booking
            gateway.StartBooking();
            try
            {
                Assert.Throws<BookingInProgressException>(() => gateway.StartBooking()); // BookingInProgressException expected when call again

                // other thread try access to StartBooking
                var thread1 = System.Threading.Tasks.Task.Run(() =>
                {
                    Assert.Throws<BookingInProgressException>(() => gatewayForThread1.StartBooking()); // expected exception
                });

                thread1.Wait(5000);
            }
            finally
            {
                gateway.EndBooking(); // finish booking
            }
        }

        #endregion StartBooking-tests

        #region EndBooking-tests

        /// <summary>
        /// Check is EndBooking implemented
        /// </summary>
        [Timeout(5000)]
        [Test]
        [NonParallelizable]
        public void EndBookingImplementationTest()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);
            gateway.StartBooking(); // must be called before EndBooking
            gateway.EndBooking();
            Assert.Throws<NoStartBookingException>(() => gateway.EndBooking()); // try end again...
        }

        /// <summary>
        /// Check is EndBooking implemented
        /// </summary>
        [Timeout(5000)]
        [Test]
        [NonParallelizable]
        public void EndBookingBeforeStartBookingImplementationTest()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);
            Assert.Throws<NoStartBookingException>(() => gateway.EndBooking()); // try end before start
        }

        #endregion EndBooking-tests

        #region GetBookingStatuses-tests

        /// <summary>
        /// `IBookingGateway.GetBookingStatuses` should return information on transaction statuses. 
        /// You have to use `IDBRepository.GetStatuses` to get the required data from the repository.
        /// </summary>
        [Timeout(5000)]
        [Test]
        [NonParallelizable]
        public void CheckGetBookingStatusesTest()
        {
            var fakeDB = new FakeDBRepository();
            fakeDB.Data.Add(new BookingGatewayRepository.Model.TransactionData() { Amount = 100, DestAccountNo = "DST-ACC-1", SourceAccountNo = "SRC-ACC-1", TransactionTitle = "Title 1", UniqueRef = "REF1" });
            fakeDB.Data.Add(new BookingGatewayRepository.Model.TransactionData() { Amount = 100, DestAccountNo = "DST-ACC-2", SourceAccountNo = "SRC-ACC-2", TransactionTitle = "Title 2", UniqueRef = "REF2" });
            fakeDB.Data.Add(new BookingGatewayRepository.Model.TransactionData() { Amount = 100, DestAccountNo = "DST-ACC-3", SourceAccountNo = "SRC-ACC-3", TransactionTitle = "Title 3", UniqueRef = "REF3" });
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);

            var statuses = gateway.GetBookingStatuses(new List<string>() { "REF1", "REF2", "REF3", "REF4" });
            Assert.AreEqual(3, statuses.Count);

            statuses = gateway.GetBookingStatuses(new List<string>() { "REF1" });
            Assert.AreEqual(1, statuses.Count);
        }

        /// <summary>
        ///  Calling IBookingGateway.GetBookingStatuses by thread when booking is in progress should throw BookingInProgressException
        /// </summary>
        [Timeout(5000)]
        [Test]
        [NonParallelizable]
        public void GetBookingStatuses_BookingInProgressException_Test()
        {
            FakeDBRepository fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            var gatewayInstance2 = BookingGatewayFactory.CreateGateway(fakeDB);

            Assert.IsNotNull(gateway);
            Assert.IsNotNull(gatewayInstance2);

            // booking by main thread
            gateway.StartBooking();
            try
            {
                var thread1 = System.Threading.Tasks.Task.Run(() =>
                {
                    Assert.Throws<BookingInProgressException>(() => gatewayInstance2.GetBookingStatuses(new List<string> { "ref3" })); // should throw BookingInProgressException
                });

                thread1.Wait(5000);                
            }
            finally
            {
                gateway.EndBooking();
            }
        }

        /// <summary>
        /// `IBookingGateway.GetBookingStatuses` should return an empty list if the passed parameter is null or empty or if there are no results from the DB (from `IDBRepository.GetStatuses`).
        /// </summary>
        [Test]
        [NonParallelizable]
        public void Check_GetBookingStatuses_EmptListAsParam_Test()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);

            var res = gateway.GetBookingStatuses(new List<string>());
            Assert.IsTrue(res != null && res.Count == 0);
        }

        /// <summary>
        /// `IBookingGateway.GetBookingStatuses` should return an empty list if the passed parameter is null or empty or if there are no results from the DB (from `IDBRepository.GetStatuses`).
        /// </summary>
        [Test]
        [NonParallelizable]
        public void Check_GetBookingStatuses_EmptListAsParam_NullFromDB_Test()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);

            // database returns null;
            fakeDB.Data = null;

            var res = gateway.GetBookingStatuses(new List<string>());
            Assert.IsTrue(res != null && res.Count == 0);
        }

        #endregion GetBookingStatuses-tests

        #region Booking-tests

        /// <summary>
        /// `IBookingGateway.Booking` should save the transaction data to a local repository using the `IDBRepository.SaveBooking` method.
        /// </summary>
        [Timeout(5000)]
        [Test]
        [NonParallelizable]
        public void CheckBookingTest()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);

            gateway.StartBooking(); // must be called before EndBooking
            try
            {
                gateway.Booking("ref1", 100, "title", "123", "456");
                gateway.Booking("ref2", 200, "title 2", "123", "456");
                gateway.GetBookingStatuses(new List<string>() { "noneRef" });
            }
            finally
            {
                gateway.EndBooking();
            }
            Assert.AreEqual(2, fakeDB.Data.Count);
        }


        /// <summary>
        /// Check are data correctly saved.
        /// </summary>
        [Timeout(5000)]
        [Test]
        [NonParallelizable]
        public void CheckBookingDataTest()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);
            Assert.AreEqual(0, fakeDB.Data.Count);

            gateway.StartBooking();
            try
            {
                gateway.Booking("ref1", 100m, "title", "123", "456");
                gateway.Booking("ref2", 200m, "title 2", "123", "456");
            }
            finally
            {
                gateway.EndBooking();
            }

            Assert.AreEqual(2, fakeDB.Data.Count);
            Assert.AreEqual(100m, fakeDB.Data[0].Amount);
            Assert.AreEqual("title", fakeDB.Data[0].TransactionTitle);
            Assert.AreEqual("123", fakeDB.Data[0].SourceAccountNo);
            Assert.AreEqual("456", fakeDB.Data[0].DestAccountNo);
            Assert.AreEqual("ref1", fakeDB.Data[0].UniqueRef);
        }

        #endregion Booking-tests
    }
}
