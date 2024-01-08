using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeebShop.Core.Contracts
{
    public interface IAccount
    {
        string FirstName { get;set; }
        string LastName { get;set; }
        string Email { get;set; }
        string Password { get;set; }   
    }
}
