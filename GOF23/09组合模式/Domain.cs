using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._09组合模式
{
    /// <summary>
    /// 抽象 机构/个人
    /// </summary>
    public class Domain: AbstractDomain
    {
        protected List<Domain> DomainChildList = new List<Domain>();

        /// <summary>
        /// 添加子节点
        /// </summary>
        /// <param name="domainChild"></param>
        public override void AddChild(Domain domainChild)
        {
            this.DomainChildList.Add(domainChild);
        }

        /// <summary>
        /// 提成
        /// </summary>
        /// <param name="total"></param>
        public override void Commission(double total)
        {
            double result = total * this.Percent / 100;
            Console.WriteLine("this {0} 提成 {1}", this.Name, result);
            foreach (var domainChild in DomainChildList)
            {
                domainChild.Commission(result);
            }
        }

    }
}
