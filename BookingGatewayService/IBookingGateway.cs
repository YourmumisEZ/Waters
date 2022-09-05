using BookingGatewayRepository;
using BookingGatewayRepository.Model;
using System.Collections.Generic;

namespace BookingGatewayService
{
    /// <summary>
    /// Booking gateway use by all threads that process transactions.
    /// TODO: You should create class that have to implement this interface!
    /// </summary>
    public interface IBookingGateway
    {
        /// <summary>
        /// Interface to DB.
        /// </summary>
        IDBRepository DBRepository { get; set; }

        /// <summary>
        /// Start booking process by thread
        /// </summary>
        void StartBooking();

        /// <summary>
        /// Finish booking process by thread
        /// </summary>
        void EndBooking();

        /// <summary>
        /// Booking transaction (save transaction in DB using IDBRepository).
        /// The method should map parameters to TransactionData.
        /// </summary>
        /// <param name="uniqueReference">Unique transaction reference</param>
        /// <param name="amount">Amount</param>
        /// <param name="transactonTitle">Transaction title</param>
        /// <param name="srcAccountNo">Source account number</param>
        /// <param name="destAccountNo">Destination account number</param>
        void Booking(string uniqueReference, decimal amount, string transactonTitle, string srcAccountNo, string destAccountNo);

        /// <summary>
        /// Returns transaction statuses.
        /// </summary>
        /// <param name="uniqueTransactionRefs">Transactions unique identifiers</param>
        /// <returns>List of statuses for transactions</returns>
        IList<TransactionStatus> GetBookingStatuses(IList<string> uniqueTransactionRefs);
    }
}
