using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Contracts;

namespace WeebShop.Core.Entities
{
    public class Image:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int ProductID { get; set; }  
        public Product Product { get; set; }
        public int BrandID { get;set; }
        public Brand Brand { get; set; }
    }
}
