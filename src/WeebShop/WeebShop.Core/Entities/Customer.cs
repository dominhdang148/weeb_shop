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
        public int Id { get; set; }
        public string Email { get;set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set ; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }    
    }
}
