using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Contracts;

namespace WeebShop.Core.Entities
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Meta { get; set; }
        public string UrlSlug { get; set; }
        public IList<String> ImageURLs { get;set; }
        public int Inventory { get; set; }
        public bool Published { get; set; }
        public DateTime PostedDate { get;set; }
        public double Price { get; set; }

        public int CategoryId { get; set; }
        public int BrandId { get; set; }    
        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public List<Tag> Tags { get; set; }

    }
}
    