using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._09组合模式
{
    /// <summary>
    /// 机构/个人
    /// </summary>
    public abstract class AbstractDomain
    {
        public string Name { get; set; }
        /// <summary>
        /// 提成百分比
        /// </summary>
        public double Percent { get; set; }

        /// <summary>
        /// 添加子节点
        /// </summary>
        /// <param name="domainChild"></param>
        public abstract void AddChild(Domain domainChild);
        /// <summary>
        /// 提成
        /// </summary>
        /// <param name="total"></param>
        public abstract void Commission(double total);

    }
}
