using System;
using System.Collections.Generic;
using System.Text;

namespace BookingGatewayRepository.Model
{
    public class TransactionStatus
    {
        /// <summary>
        /// Unique transaction reference
        /// </summary>
        public string UniqueRef { get; set; }

        /// <summary>
        /// Transaction status (description)
        /// </summary>
        public string Status { get; set; }
    }
}
