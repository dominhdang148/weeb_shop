using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Contracts;

namespace WeebShop.Core.Entities
{
    public class PaymentMethod : IEntity
    {
        #region Primary Key

        public int Id { get; set; }

        #endregion

        #region Properties

        public string Provider { get; set; }
        public string AccountNo { get; set; }
        public DateTime Expiry { get; set; }

        #endregion

        #region Foreign Key
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        #endregion


    }
}
