﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._11外观模式.Order
{
    /// <summary>
    /// 订单
    /// </summary>
    public class OrderSystem : IOrderSystem
    {
        public bool CheckOrder(int userId, int productId)
        {
            return true;
        }

        public void NewOrder(int userId, int productId)
        {
            Console.WriteLine("{0}给商品{1}下订单", userId, productId);
        }
    }
}
