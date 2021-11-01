using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brokerage_Platform.Models
{
    public class TradersModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string BirthPlace { get; set; }
    }
}