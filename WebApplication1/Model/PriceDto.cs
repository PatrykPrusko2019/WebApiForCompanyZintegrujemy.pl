using System.Diagnostics.Metrics;
using WebApplication1.Entities;

namespace WebApplication1.Model
{
    public class PriceDto
    {
        public string SKU { get; set; }
        public double? NettProductPrice { get; set; }
        public double? NettProductPriceAfterDiscountForProductLogisticUnit { get; set; }
    }
}
