﻿namespace FullEcommerce.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public string PictureUrl { get; set; } = string.Empty;

        public int ProductTypeId { get; set; }

        public ProductType? ProductType { get; set; }

        public int ProductBrandId { get; set; }

        public ProductBrand? ProductBrand { get; set; }



    }
}
