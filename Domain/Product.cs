using System;
using System.Collections.Generic;

namespace Domain
{
    public enum ProductCategoryEnum
    {
        Car,
        Phone
    }

    public abstract class Product : BaseClass
    {
        public Guid BranchId { get; set; }
        public ProductCategoryEnum Category { get; set; }
        public decimal Value { get; set; }
    }
}
