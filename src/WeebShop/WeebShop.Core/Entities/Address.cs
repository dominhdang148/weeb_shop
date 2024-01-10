using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Contracts;

namespace WeebShop.Core.Entities
{
    public class Address : IEntity
    {
        #region Primary Keys
        public int Id { get; set; }
        #endregion

        #region Properties
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set;}
        public string Country { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        #endregion

        #region Foreign Key
        public int CustomerId { get; set; } 
        public Customer Customer { get; set; }
        #endregion
    }
}
