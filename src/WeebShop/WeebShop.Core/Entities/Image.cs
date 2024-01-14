using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Contracts;

namespace WeebShop.Core.Entities
{
    public class Image : IEntity
    {
        #region Primary Ksey
        public int Id { get; set; }
        #endregion
         
        #region Properties
        public string Alternative { get; set; }
        public string Url { get; set; } 
        #endregion

       
    }
}
