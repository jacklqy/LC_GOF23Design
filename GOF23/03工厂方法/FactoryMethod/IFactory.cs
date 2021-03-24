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
    /// 工厂抽象类
    /// </summary>
    public interface IFactory
    {
        IRace CreateInstance();
    }
}
