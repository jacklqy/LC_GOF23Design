using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._15模板模式
{
    /// <summary>
    /// 活期客户
    /// </summary>
    public class ClientCurrent : ClientTemplate
    {
        /// <summary>
        /// 获取利率，计算利息
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public override double CalculateInterest(double balance)
        {
            return balance * 0.03;
        }
    }
}
