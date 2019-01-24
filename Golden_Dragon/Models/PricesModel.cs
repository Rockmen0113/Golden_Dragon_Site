using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Golden_Dragon.Models
{
    public class PricesModel
    {
        public int ID { get; set; }
        public HotelRoomModel hotelRoom { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public bool isSpecial { get; set; }
    }
}