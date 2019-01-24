using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Golden_Dragon.Models
{
    public class HotelRoomModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string[] ImagesPath { get; set; }
        public string Description { get; set; }
    }
}