﻿using HXShopCoreApp.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HXShopCoreApp.Data.Entities
{
    public class ProductTag: DomainEntity<int>
    {
        
        public  int ProductId { get; set; }

        [StringLength(50)]
        [Column(TypeName ="VARCHAR(50)")]
        public string TagId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }


    }
}
