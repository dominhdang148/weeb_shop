using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeebShop.Core.Contracts
{
    public enum OrderStatus
    {
        Created,
        Preparing,
        Deliverying,
        Completed,
    }
}
