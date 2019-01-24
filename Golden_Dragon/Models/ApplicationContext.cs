using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Golden_Dragon.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<PricesModel> Price { get; set; }

        public DbSet<HotelRoomModel> Hotel_Room{ get; set; }
    }
}