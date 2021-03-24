using GOF23._03工厂方法.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._03工厂方法.Service
{
    public class Five : IRace
    {
        /// <summary>
        /// 对象构造初始化
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="special"></param>
        public Five(string name,int id,object special)
        {

        }
        public void ShowKing()
        {
            throw new NotImplementedException();
        }
    }
}
