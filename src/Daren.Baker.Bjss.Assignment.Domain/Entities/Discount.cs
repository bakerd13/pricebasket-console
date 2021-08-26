using Daren.Baker.Bjss.Assignment.Domain.Enums;
using System;

namespace Daren.Baker.Bjss.Assignment.Domain.Entities
{
    public class Discount : BaseEntityGuidKey
    {
        /// <summary>
        /// Value of the discount
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Discount Type used for calculating discounts
        /// </summary>
        public DiscountType DiscountType { get; set; }

        /// <summary>
        /// Quantity for this discount to apply
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Product that this discount applies too.
        /// </summary>
        public Guid? ProductId { get; set; }
    }
}
