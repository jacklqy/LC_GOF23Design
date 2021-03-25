using GOF23._04抽象工厂.Interface;
using GOF23._04抽象工厂.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._04抽象工厂.Factory
{
    /// <summary>
    /// 抽象工厂类
    /// 产品族扩展方便
    /// 工厂职责不能扩展，否则所有实现都将调整，违背了开闭原则。
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract IGroup CreateGroup();

        public abstract IGenerals CreateGenerals();

        //public abstract IAdviser CreateAdviser();
    }
}
