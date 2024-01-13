using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeebShop.Core.Contracts
{
    public interface IUser
    {
        string Email { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string FirstName { get; set; } 
        string LastName { get; set; }   
        DateTime CreatedAt { get; set; }
        DateTime ModifiedAt { get; set; }
    }
}
