using GOF23._11外观模式.Logistics;
using GOF23._11外观模式.Order;
using GOF23._11外观模式.Storage;
using GOF23._11外观模式.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._11外观模式
{
    /// <summary>
    /// 外观模式 通常是单列的
    /// </summary>
    public class FacadeCenter
    {
        private static FacadeCenter _FacadeCenter = new FacadeCenter();
        private FacadeCenter()
        {

        }
        public static FacadeCenter CreateInstance()
        {
            return _FacadeCenter;
        }
        public void NewOrder(int userId, int productId,int cityId)
        {
            ILogisticsSystem iLogisticsSystem = new LogisticsSystem();
            IOrderSystem iOrderSystem = new OrderSystem();
            IStorageSystem iStorageSystem = new StorageSystem();
            IUserSystem iUserSystem = new UserSystem();
            if (!iUserSystem.CheckUser(userId))
            {
                Console.WriteLine("用户检测失败");
            }
            else if (!iStorageSystem.CheckStorage(productId))
            {
                Console.WriteLine("仓储检测失败");
            }
            else if (!iLogisticsSystem.CheckLogistics(productId, cityId))
            {
                Console.WriteLine("物流检测失败");
            }
            else if (!iOrderSystem.CheckOrder(userId, productId))
            {
                Console.WriteLine("订单检测失败");
            }
            else
            {
                iOrderSystem.NewOrder(userId, productId);
                iLogisticsSystem.NewLogistics(productId, cityId);
            }
        }
    }
}
