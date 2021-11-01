using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brokerage_Platform.Models
{
    public class TradeItemsModel
    {
        public Guid ItemId { get; set; }

        public string Symbol { get; set; }

        public string Description { get; set; }

        public Guid AccNumber { get; set; }


    }
}