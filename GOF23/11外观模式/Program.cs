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
    /// 意图：为子系统中的一组接口提供一个一致的界面，外观模式定义了一个高层接口，这个接口使得这一子系统更加容易使用。
    /// 主要解决：降低访问复杂系统的内部子系统时的复杂度，简化客户端与之的接口。
    /// 何时使用： 
    ///     1、客户端不需要知道系统内部的复杂联系，整个系统只需提供一个"接待员"即可。 
    ///     2、定义系统的入口。
    /// 如何解决：客户端不与系统耦合，外观类与系统耦合。
    /// 关键代码：在客户端和复杂系统之间再加一层，这一层将调用顺序、依赖关系等处理好。
    /// 应用实例： 
    ///     1、去医院看病，可能要去挂号、门诊、划价、取药，让患者或患者家属觉得很复杂，如果有提供接待人员，只让接待人员来处理，就很方便。 
    ///     2、JAVA 的三层开发模式。
    /// 使用场景： 
    ///     1、为复杂的模块或子系统提供外界访问的模块。 
    ///     2、子系统相对独立。 
    ///     3、预防低水平人员带来的风险。
    /// 优点： 
    ///     1、减少系统相互依赖。 
    ///     2、提高灵活性。 
    ///     3、提高了安全性。
    /// 缺点：不符合开闭原则，如果要改东西很麻烦，继承重写都不合适。
    /// </summary>
    public class Program : OpentDesign
    {
        public override void Open()
        {
            Console.WriteLine("***************外观模式************");
            //模拟一个业务场景：用户需要登录检测，然后检测库存、物流、订单，检测通过后才能下单。

            int userId = 123;
            int productId = 123456;
            int cityId = 1;
            FacadeCenter facadeCenter = FacadeCenter.CreateInstance();
            facadeCenter.NewOrder(userId, productId, cityId);
            {
                //ILogisticsSystem iLogisticsSystem = new LogisticsSystem();
                //IOrderSystem iOrderSystem = new OrderSystem();
                //IStorageSystem iStorageSystem = new StorageSystem();
                //IUserSystem iUserSystem = new UserSystem();
                
                //if (!iUserSystem.CheckUser(userId))
                //{
                //    Console.WriteLine("用户检测失败");
                //}
                //else if (!iStorageSystem.CheckStorage(productId))
                //{
                //    Console.WriteLine("仓储检测失败");
                //}
                //else if (!iLogisticsSystem.CheckLogistics(productId, cityId))
                //{
                //    Console.WriteLine("物流检测失败");
                //}
                //else if (!iOrderSystem.CheckOrder(userId, productId))
                //{
                //    Console.WriteLine("订单检测失败");
                //}
                //else
                //{
                //    iOrderSystem.NewOrder(userId, productId);
                //    iLogisticsSystem.NewLogistics(productId, cityId);
                //}
            }
        }
    }
}
