﻿using ECommerceAPI.Domain.Common.Abstracts;

namespace ECommerceAPI.Domain.Entities.Products
{
    public class ProductImage : BaseEntity
    {
        #region Properties
        public string? Url { get; set; }
        #endregion

        #region Relationships
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        #endregion
    }
}
