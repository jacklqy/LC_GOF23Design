using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GOF23._18迭代器模式
{
    public class Food //: IEnumerable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
            //返回一个迭代器
        }
    }
}
