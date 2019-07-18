using System;

namespace home_work_17_07_2019
{
   public class Category
    {
        private static int _counter = 1;
        public string Id { get; private set; }
        public string Name { get; set; }

        public Category()
        {
            #region Id Dynamic Create To Product

            //if (_counter.ToString().Length == 1)
            //{
            //    Id = "0000" + _counter;
            //}
            //if(_counter.ToString().Length == 2)
            //{
            //    Id = "000" + _counter;

            //}
            //if (_counter.ToString().Length == 3)
            //{
            //    Id = "00" + _counter;

            //}
            //if (_counter.ToString().Length == 4)
            //{
            //    Id = "0" + _counter;

            //}
            //else 
            //{
            //    Id = _counter.ToString();

            //}
            #endregion

            #region Id Dynamic Create To Product Main
            string id = new string('0', 5 - _counter.ToString().Length) + _counter.ToString();
            _counter++;
            #endregion
        }

        public static implicit operator string(Category v)
        {
            throw new NotImplementedException();
        }
    }
}
