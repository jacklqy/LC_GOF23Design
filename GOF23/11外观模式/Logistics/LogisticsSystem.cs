using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._11外观模式.Logistics
{
    /// <summary>
    /// 物流
    /// </summary>
    public class LogisticsSystem : ILogisticsSystem
    {
        public bool CheckLogistics(int productId, int cityId)
        {
            //远程接口
            //本地缓存
            //搜索引擎
            return true;
        }

        public void NewLogistics(int productId, int cityId)
        {
            Console.WriteLine("{0}城市 商品{1}的物流订单", cityId, productId);
        }
    }
}
