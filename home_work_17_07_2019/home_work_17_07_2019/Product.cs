using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_17_07_2019
{
    public class Product
    {
        private static int _counter = 1000;
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string CategoryId { get; set; }
        public Product()
        {
            Id = new string('0', 10 - _counter.ToString().Length) + _counter.ToString();
            _counter++;
        }
    }

    public class DiaryProducts : Product
    {

    }
}
