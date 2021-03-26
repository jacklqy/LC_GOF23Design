using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GOF23._06原型模式
{
    /// <summary>
    /// 单列类
    /// </summary>
    public class StudentSingleton
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        /// <summary>
        /// 1、私有化构造函数
        /// </summary>
        private StudentSingleton()
        {
            //模拟创建对象耗时操作
            Thread.Sleep(2000);
            long iResult = 0;
            for (int i = 0; i < 1000000; i++)
            {
                iResult += i;
            }
            Console.WriteLine("{0}被构造了.", this.GetType().Name);
        }

        /// <summary>
        /// 2、私有静态字段--有CLR保证创建，内存唯一，不会释放，且在第一次使用这个类时被初始化，且只初始化一次。
        /// </summary>
        private static StudentSingleton _StudentSingleton = new StudentSingleton()
        {
            Id = 123,
            Name = "犀利哥"
        };

        /// <summary>
        /// 3、公开静态方法来提供实例
        /// </summary>
        /// <returns></returns>
        public static StudentSingleton GetInstance()
        {
            return _StudentSingleton;
        }
        public void Study()
        {
            Console.WriteLine("{0}.{1}被调用啦.Id={2} Name={3}", this.GetType().Name, "Study", this.Id, this.Name);
        }
    }
}
