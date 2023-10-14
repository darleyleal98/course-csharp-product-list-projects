using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_product_list.Entities
{
    public class UsedProduct : Product
    {
        protected DateTime ManufactureDate { get; set; }
        public UsedProduct() { }
        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{Name} (used) {Price:c} (Manufacture date: {ManufactureDate})");
            return builder.ToString();
        }
    }
}
