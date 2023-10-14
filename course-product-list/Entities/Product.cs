using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_product_list.Entities
{
    public class Product
    {
        protected string Name {  get; set; }
        protected double Price { get; set; }
        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual string PriceTag()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"{Name} {Price:c}");
            return builder.ToString();
        }
    }
}
