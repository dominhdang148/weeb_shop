﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebShop.Core.Contracts;

namespace WeebShop.Core.Entities
{
    public class Brand : IEntity
    {
        #region Primary Key
        public int Id { get; set; }
        #endregion

        #region Properties
        public string Name { get; set; }    
        public string Description { get; set; }
        public string UrlSlug { get; set; }
        public string Website { get; set; }

        #endregion

    }
}
