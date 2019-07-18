using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_17_07_2019
{
    public static class ProductList
   {
        private static Product[] products = new Product[7] {
            new Product {Name = "Yogurt", Price = 2, CategoryId = "00001" },
            new Product {Name = "Milk", Price = 4,CategoryId = "00001" },
            new Product {Name = "Sausage", Price = 2, CategoryId = "00002"},
            new Product {Name = "Bread", Price = 2, CategoryId = "00003"},
            new Product {Name = "Bakhlava", Price = 2, CategoryId = "00003"},
            new Product {Name = "Cheese", Price = 0.5M, CategoryId = "00001"},
            new Product {Name = "Lamb", Price = 20, CategoryId = "00002"}
        };
        public static Product[] GetProducts() => products;

   }
}
