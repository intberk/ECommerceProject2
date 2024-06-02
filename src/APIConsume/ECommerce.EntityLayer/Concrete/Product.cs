using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
    public class Product : BaseEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal UnitPrice { get; set; }
        public string UnitsInStock { get; set; }
        public string ImageFile { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }


        public int CategoryId { get; set; }

        //Relational Properties
        [JsonIgnore]
        public virtual Category Category { get; set; }

    }
}
