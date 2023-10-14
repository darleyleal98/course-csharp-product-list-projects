using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_product_list.Entities
{
    public class ImportedProduct : Product
    {
        protected double CustomsFee {  get; set; }
        public ImportedProduct() { }    
        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }
        public override string PriceTag()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{Name} {Price:c} (Customs fee: {TotalPrice:c})");
            return builder.ToString();
        }
        public double TotalPrice() => (Price + CustomsFee);
    }
}
