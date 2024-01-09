﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Contracts;

namespace WeebShop.Core.Entities
{
    public class OrderItem:IEntity
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }    
        public int ProductId { get; set; }
        public double ItemPrice { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
 