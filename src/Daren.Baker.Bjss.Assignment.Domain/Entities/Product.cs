using System.Globalization;

namespace Daren.Baker.Bjss.Assignment.Domain.Entities
{
    public class Product : BaseEntityGuidKey
    {
        /// <summary>
        /// Name of the Product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The packaging that the product is sold as.
        /// </summary>
        public string ContainerType { get; set; }

        /// <summary>
        /// The packaging that the product is sold as.
        /// </summary>
        public int Packaging { get; set; }

        /// <summary>
        /// Unit Price
        /// </summary>
        public double UnitPrice { get; set; }

        /// <summary>
        /// Product Culture
        /// </summary>
        public CultureInfo Culture { get; set; } = new CultureInfo("en-GB");
    }
}
