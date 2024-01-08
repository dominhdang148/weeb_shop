using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Contracts;

namespace WeebShop.Core.Entities
{
    public class Admin : IEntity, IAccount
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        // Superadmins have ability to manage other accounts
        public bool IsSuperadmin { get; set; }
        public DateTime JoinedDate { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get;set; }
        public ActivateStatus AccountStatus { get; set; }        
    }
}
