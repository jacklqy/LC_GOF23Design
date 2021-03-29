using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._11外观模式.Order
{
    /// <summary>
    /// 订单接口
    /// </summary>
    public interface IOrderSystem
    {
        public bool CheckOrder(int userId, int productId);
        public void NewOrder(int userId, int productId);
    }
}
