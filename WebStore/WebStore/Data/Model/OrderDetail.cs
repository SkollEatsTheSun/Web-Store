﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Data.Model
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int CarId { get; set; }
        public uint price { get; set; }
        public virtual Car car { get; set; }
        public virtual Order order { get; set; }
    }
}
