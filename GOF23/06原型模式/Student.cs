using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GOF23._06原型模式
{
    /// <summary>
    /// 普通类
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student()
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
        public void Study()
        {
            Console.WriteLine("{0}.{1}被调用啦.Id={2} Name={3}", this.GetType().Name, "Study", this.Id, this.Name);
        }
    }
}
