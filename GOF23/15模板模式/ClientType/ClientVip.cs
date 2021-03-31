using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._15模板模式
{
    /// <summary>
    /// vip客户
    /// </summary>
    public class ClientVip : ClientTemplate
    {
        /// <summary>
        /// 获取利率，计算利息
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public override double CalculateInterest(double balance)
        {
            return balance * 0.07;
        }
        /// <summary>
        /// 虚方法子类可以不覆写，个别子类有特殊要求就覆写，如果没有特殊要求就沿用父类这个方法
        /// 
        /// 展示
        /// </summary>
        /// <param name="name"></param>
        /// <param name="balance"></param>
        /// <param name="intersest"></param>
        public override void Show(string name, double balance, double intersest)
        {
            //Console.WriteLine("尊敬的{0}客户，你的账户余额为：{1}，利息为：{2}", name, balance, intersest);
            Console.WriteLine("尊贵的{0}客户，你的账户余额为：{1}，利息为：{2}", name, balance, intersest);
            Console.WriteLine("理财有风险，入行需谨慎");
        }
    }
}
