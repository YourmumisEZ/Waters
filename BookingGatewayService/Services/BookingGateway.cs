using BookingGatewayRepository;
using BookingGatewayRepository.Model;
using BookingGatewayService.Exceptions;
using BookingGatewayService.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookingGatewayService.Services
{
    public sealed class BookingGateway : IBookingGateway
    {
        private bool isBookingStarted;
        private IDBRepository dbRepository;

        public BookingGateway(IDBRepository dbRepository)
        {
            Singleton semaphore = Singleton.Instance;
            isBookingStarted = false;

            this.dbRepository = dbRepository;
        }

        IDBRepository IBookingGateway.DBRepository
        {
            get
            {
                return dbRepository;
            }
            set
            {
                dbRepository = value;
            }
        }
        public void Booking(string uniqueReference, decimal amount, string transactonTitle, string srcAccountNo, string destAccountNo)
        {
            if (!isBookingStarted)
            {
                throw new NoStartBookingException();
            }

            dbRepository.SaveBooking(new TransactionData
            {
                Amount = amount,
                DestAccountNo = destAccountNo,
                SourceAccountNo = srcAccountNo,
                TransactionTitle = transactonTitle,
                UniqueRef = uniqueReference
            });
        }

        public void EndBooking()
        {
            if (!isBookingStarted)
            {
                throw new NoStartBookingException();
            }

            Singleton.ReleaseSemaphore();
        }

        public IList<TransactionStatus> GetBookingStatuses(IList<string> uniqueTransactionRefs)
        {
            var result = new List<TransactionStatus>();
            if (!isBookingStarted && Singleton.IsBookingBlocked())
            {
                throw new BookingInProgressException();
            }

            Singleton.IncreaseGetStatusCounter();

            if (uniqueTransactionRefs != null && uniqueTransactionRefs.Any())
            {
                var statuses = dbRepository.GetStatuses(uniqueTransactionRefs.ToArray());
                if (statuses?.Length > 0)
                {
                    result = statuses.ToList();
                }
            }

            return result;
        }

        public void StartBooking()
        {
            if (Singleton.IsBookingBlocked())
            {
                throw new BookingInProgressException();
            }

            if (Singleton.GetGetStatusCounter() > 0)
            {
                throw new ReadOperationInProgressException();
            }

            Singleton.BlockSemaphore();
            isBookingStarted = true;
        }
    }
}
