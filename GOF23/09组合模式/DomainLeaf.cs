using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._09组合模式
{
    /// <summary>
    /// 抽象 机构/个人
    /// </summary>
    public class DomainLeaf : AbstractDomain
    {
        /// <summary>
        /// 添加子节点
        /// </summary>
        /// <param name="domainChild"></param>
        public override void AddChild(Domain domainChild)
        {
            throw new Exception("此节点没有子节点！！！");
        }

        /// <summary>
        /// 提成
        /// </summary>
        /// <param name="total"></param>
        public override void Commission(double total)
        {
            double result = total * this.Percent / 100;
            Console.WriteLine("this {0} 提成 {1}", this.Name, result);
        }

    }
}
