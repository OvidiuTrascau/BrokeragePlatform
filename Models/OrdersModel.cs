using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brokerage_Platform.Models
{
    public class OrdersModel
    {
        public Guid Id { get; set; }

        public DateTime OpenDate { get; set; }

        public DateTime CloseDate { get; set; }

        public double Size { get; set; }

        public double Price { get; set; }

        public double StopLoss { get; set; }

        public double TakeProfit { get; set; }

        public double Commission { get; set; }

        public Guid AccNumber {get;set;}

        public Guid OrderTypeId { get; set; }


        


    }
}