using GOF23._04抽象工厂.Interface;
using GOF23._04抽象工厂.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._04抽象工厂.Factory
{
    /// <summary>
    /// 蜀国工厂类
    /// </summary>
    public class FactoryShu : AbstractFactory
    {
        public override IGroup CreateGroup()
        {
            return new GroupShu();
        }

        public override IGenerals CreateGenerals()
        {
            return new GeneralsShu();
        }

        public IAdviser CreateAdviser()
        {
            return new AdviserShu();
        }
    }
}
