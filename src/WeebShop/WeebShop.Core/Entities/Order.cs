using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Contracts;

namespace WeebShop.Core.Entities
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public double TotalAmount { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int CustomerId { get; set;}  
        public Customer Customer { get; set; } 
    }
}
