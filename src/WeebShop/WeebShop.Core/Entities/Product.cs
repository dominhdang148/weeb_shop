using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Contracts;

namespace WeebShop.Core.Entities
{
    public class Product : IEntity
    {
        #region Primary Key
        public int Id { get; set; }
        #endregion

        #region Properties
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        public string Metadata { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsPublished { get; set; }
        #endregion

        #region Foreign Key

        #endregion
    }
}
