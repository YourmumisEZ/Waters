using System;
using System.Collections.Generic;
using System.Text;

namespace BookingGatewayRepository.Model
{
    /// <summary>
    /// Transaction data
    /// </summary>
    public class TransactionData
    {
        /// <summary>
        /// Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Transaction title
        /// </summary>
        public string TransactionTitle { get; set; }

        /// <summary>
        /// Source account number
        /// </summary>
        public string SourceAccountNo { get; set; }

        /// <summary>
        /// Destination account number
        /// </summary>
        public string DestAccountNo { get; set; }

        /// <summary>
        /// Unique transaction reference
        /// </summary>
        public string UniqueRef { get; set; }
    }
}
