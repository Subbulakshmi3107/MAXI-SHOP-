﻿using MaxiShop.Domain.Common;
using MaxiShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiShop.Domain.Model
{
    public class Category : BaseModel
    {

        [Required]
        public string Name { get; set; }
    }
}

