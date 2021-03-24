using GOF23._03工厂方法.Interface;
using GOF23._03工厂方法.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace GOF23.FactoryMethod._03工厂方法
{
    /// <summary>
    /// 工厂类
    /// </summary>
    public class ORCFactory : IFactory
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IRace CreateInstance()
        {
            IRace iRace = new ORC();
            return iRace;
        }

    }
}
