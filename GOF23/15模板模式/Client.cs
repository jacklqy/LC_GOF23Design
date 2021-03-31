using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._15模板模式
{
    /// <summary>
    /// 银行客户端模拟
    /// </summary>
    public class Client
    {
        /// <summary>
        /// 登录查询功能
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public void Query(int id,string name,string password)
        {
            if (this.CheckUser(id, password))
            {
                double balance = this.QueryBalance(id);
                double interest = this.CalculateInterest(balance);
                this.Show(name, balance, interest);
            }
            else
            {
                Console.WriteLine("账户密码错误");
            }
        }
        /// <summary>
        /// 用户检测
        /// </summary>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckUser(int id,string password)
        {
            return true;
        }
        /// <summary>
        /// 余额查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public double QueryBalance(int id)
        {
            return new Random().Next(100000, 10000000);
        }
        /// <summary>
        /// 获取利率，计算利息
        /// 定期 0.05
        /// 活期 0.03
        /// 在增加一个呢...
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public double CalculateInterest(double balance)
        {
            //常规思路
            //if (定期) { 
            //return balance * 0.05;
            //}else {
            //return balance * 0.03;
            //}
            return balance * 0.03;
        }
        /// <summary>
        /// 展示
        /// </summary>
        /// <param name="name"></param>
        /// <param name="balance"></param>
        /// <param name="intersest"></param>
        public void Show(string name,double balance,double intersest)
        {
            Console.WriteLine("尊敬的{0}客户，你的账户余额为：{1}，利息为：{2}", name, balance, intersest);
        }
    }
}
