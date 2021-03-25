using GOF23._04抽象工厂.Interface;
using GOF23._04抽象工厂.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._04抽象工厂.Factory
{
    /// <summary>
    /// 魏国工厂类
    /// </summary>
    public class FactoryWei : AbstractFactory
    {
        public override IGroup CreateGroup()
        {
            return new GroupWei();
        }

        public override IGenerals CreateGenerals()
        {
            return new GeneralsWei();
        }

        //public override IAdviser CreateAdviser()
        //{
        //    throw new Exception("具体实现..");
        //}
    }
}
