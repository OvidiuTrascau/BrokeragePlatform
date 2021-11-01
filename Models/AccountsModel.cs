using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brokerage_Platform.Models
{
    public class AccountsModel
    {
        public Guid AccNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime OpenDate { get; set; }

        public Guid TradeId { get; set; }

    }
}