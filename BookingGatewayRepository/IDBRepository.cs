using BookingGatewayRepository.Model;

namespace BookingGatewayRepository
{
    public interface IDBRepository
    {
        /// <summary>
        /// Save transaction data in repository.
        /// </summary>
        /// <param name="transaction"></param>
        void SaveBooking(TransactionData transaction);

        /// <summary>
        /// Returns transaction statuses by transaction references.
        /// </summary>
        /// <param name="uniqueTransactionRefs">List of unique transactions references</param>
        /// <returns></returns>
        TransactionStatus[] GetStatuses(string[] uniqueTransactionRefs);
    }
}
