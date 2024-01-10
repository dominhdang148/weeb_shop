using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Contracts;

namespace WeebShop.Core.Entities
{
    public class Customer:IEntity, IUser
    {
        #region Primary Key
        public int Id { get; set; }
        #endregion

        #region Properites
        public string Email { get;set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set ; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        #endregion

        #region Relationships
        // One customer account can have many addresses
        public IList<Address> Addresses { get; set; }
        // One customer account can have many payment methods
        public IList<PaymentMethod> PaymentMethods { get; set; }
        #endregion
    }
}
