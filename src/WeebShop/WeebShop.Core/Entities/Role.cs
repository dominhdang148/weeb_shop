using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Contracts;

namespace WeebShop.Core.Entities
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool AccountManagement { get; set; }
        public bool ProductManagement { get; set; }
    }
}
