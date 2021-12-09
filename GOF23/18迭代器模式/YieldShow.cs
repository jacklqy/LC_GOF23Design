using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._18迭代器模式
{
    //-------------------------知识点同步------------------------
    //yield return：
    //第一种方法，是把结果集全部加载到内存中再遍历；第二种方法，客户端每调用一次，yield return就返回一个值给客户端，是"按需供给"。
    //第一种方法，客户端调用过程大致为：
    //使用yield return，客户端调用过程大致为：
    //使用yield return为什么能保证每次循环遍历的时候从前一次停止的地方开始执行呢？
    //--因为，编译器会生成一个状态机来维护迭代器的状态。
    //简单地说，当希望获取一个IEnumerable<T> 类型的集合，而不想把数据一次性加载到内存，就可以考虑使用yield return实现"按需供给"。

    //goto case/goto
    //-------------------------知识点同步------------------------
    public class YieldShow
    {
        public IEnumerable<int> CreateEnumerable()
        {
            try
            {
                Console.WriteLine("{0} CreateEnumerable()方法开始", DateTime.Now);
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("{0}开始 yield {1}", DateTime.Now, i);
                    yield return i;//状态机
                    Console.WriteLine("{0}yield 结束", DateTime.Now);
                    if (i == 4)
                    {
                        yield break;//终止迭代
                    }
                }
                Console.WriteLine("{0} yielding最后一个值",DateTime.Now); ;
                yield return -1;
                Console.WriteLine("{0} CreateEnumerable()方法结束", DateTime.Now);
            }
            finally
            {
                Console.WriteLine("停止迭代");
            }
        }

        /// <summary>
        /// MoveNext 检测是否存在 并设置current
        /// </summary>
        public void Show()
        {
            IEnumerable<int> iterable = this.CreateEnumerable();//1不会直接执行
            IEnumerator<int> iterator = iterable.GetEnumerator();
            Console.WriteLine("开始迭代");
            //这里其实就是foreach，只不过被框架封装了，我们看不见。
            while (true)
            {
                Console.WriteLine("调用MoveNext方法......");
                Boolean result = iterator.MoveNext();//2 正式开始CreateEnumerable
                Console.WriteLine("MoveNext方法返回的{0}", result);
                if (!result)
                {
                    break;
                }
                Console.WriteLine("获取当前值......");
                Console.WriteLine("获取到的当前值为{0}", iterator.Current);
            }
            Console.ReadKey();
        }
    }
}
