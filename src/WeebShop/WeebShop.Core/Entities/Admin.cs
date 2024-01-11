using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Contracts;

namespace WeebShop.Core.Entities
{
    public class Admin : IEntity, IUser
    {
        #region Primary Key
        public int Id { get; set; }
        #endregion

        #region Properties
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        #endregion


    }
}
