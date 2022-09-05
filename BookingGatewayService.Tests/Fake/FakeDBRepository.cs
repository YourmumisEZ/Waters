using BookingGatewayRepository;
using BookingGatewayRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookingGatewayService.Tests.Fake
{
    public class FakeDBRepository : IDBRepository
    {
        public IList<TransactionData> Data = new List<TransactionData>();

        public TransactionStatus[] GetStatuses(string[] uniqueTransactionRefs)
        {
            return Data?.Where(w => uniqueTransactionRefs != null && uniqueTransactionRefs.Contains(w.UniqueRef)).Select(s => new TransactionStatus() { Status = s.UniqueRef + "Status", UniqueRef = s.UniqueRef }).ToArray();
        }

        public void SaveBooking(TransactionData transaction)
        {
            Data.Add(transaction);
        }
    }
}
