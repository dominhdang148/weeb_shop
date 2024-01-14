using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Contracts;

namespace WeebShop.Core.Entities
{
    public class Inventory : IEntity
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string UrlSlug { get; set; } // Might be removed
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
       
    }
}
