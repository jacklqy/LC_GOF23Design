using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GOF23._12享元模式
{
    /// <summary>
    /// 单列模式/原型模式/享元模式
    /// 享元模式--池化资源管理---C#内存分配探讨
    /// 
    /// 意图：运用共享技术有效地支持大量细粒度的对象。
    /// 主要解决：在有大量对象时，有可能会造成内存溢出，我们把其中共同的部分抽象出来，如果有相同的业务请求，直接返回在内存中已有的对象，避免重新创建。
    /// 何时使用： 
    ///     1、系统中有大量对象。 
    ///     2、这些对象消耗大量内存。 
    ///     3、这些对象的状态大部分可以外部化。 
    ///     4、这些对象可以按照内蕴状态分为很多组，当把外蕴对象从对象中剔除出来时，每一组对象都可以用一个对象来代替。 
    ///     5、系统不依赖于这些对象身份，这些对象是不可分辨的。
    /// 如何解决：用唯一标识码判断，如果在内存中有，则返回这个唯一标识码所标识的对象。
    /// 关键代码：用 HashMap 存储这些对象。
    /// 应用实例： 
    ///     1、JAVA 中的 String，如果有则返回，如果没有则创建一个字符串保存在字符串缓存池里面。 
    ///     2、数据库的数据池。
    /// 使用场景： 
    ///     1、系统有大量相似对象。 
    ///     2、需要缓冲池的场景。
    /// 优点：大大减少对象的创建，降低系统的内存，使效率提高。
    /// 缺点：提高了系统的复杂度，需要分离出外部状态和内部状态，而且外部状态具有固有化的性质，不应该随着内部状态的变化而变化，否则会造成系统的混乱。
    /// </summary>
    public class Program : OpentDesign
    {
        public override void Open()
        {
            Console.WriteLine("*****************享元模式***************");

            {
                //准备打印个Eleven
                BaseWord e1 = new E();
                BaseWord l = new L();
                BaseWord e2 = new E();
                BaseWord v = new V();
                BaseWord e3 = new E();
                BaseWord n = new N();
                Console.WriteLine("{0}{1}{2}{3}{4}{5}", e1.Get(), l.Get(), e2.Get(), v.Get(), e3.Get(), n.Get());
            }
            Console.WriteLine("----------只实例化一个E，重用对象E，提升了性能-------");
            //下面重用了e1对象，提升了性能--其它方法、其它类、其它类库、其它线程，如果都需要重用对象来提升性能，怎么办呢？
            {
                //准备打印个Eleven
                BaseWord e1 = new E();
                BaseWord l = new L();
                //BaseWord e2 = new E();
                BaseWord v = new V();
                //BaseWord e3 = new E();
                BaseWord n = new N();
                Console.WriteLine("{0}{1}{2}{3}{4}{5}", e1.Get(), l.Get(), e1.Get(), v.Get(), e1.Get(), n.Get());
            }
            Console.WriteLine("---------单例对象比较----------");
            {
                //说到对象复用，最容易想到的是单列模式，单列可以保证进程中只有一个实例
                //那么就可以到处复用，性能优化
                //要做到单例，需要改造类，增加单例逻辑，破坏单例封装
                S s1 = S.CreateInstance();
                S s2 = S.CreateInstance();
                S s3 = S.CreateInstance();
                Console.WriteLine($"单例对象比较---{object.ReferenceEquals(s1, s2)}");
                Console.WriteLine($"单例对象比较---{object.ReferenceEquals(s1, s3)}");
            }
            //Console.WriteLine("单线程---统一入口");
            //{
            //    //有没有办法，既能对象复用，又不破坏封装？
            //    //1、统一入口---想控制全局的东西
            //    //2、添加重用逻辑，静态字典缓存一下
                
            //    //准备打印个Eleven
            //    BaseWord e1 = FlyweightFactory.CreateWord(WordType.E);
            //    BaseWord l = FlyweightFactory.CreateWord(WordType.L);
            //    //BaseWord e2 = FlyweightFactory.CreateWord(WordType.E);
            //    BaseWord v = FlyweightFactory.CreateWord(WordType.V);
            //    //BaseWord e3 = FlyweightFactory.CreateWord(WordType.E);
            //    BaseWord n = FlyweightFactory.CreateWord(WordType.N);
            //    Console.WriteLine("{0}{1}{2}{3}{4}{5}", e1.Get(), l.Get(), e1.Get(), v.Get(), e1.Get(), n.Get());
                
            //    //比较重复创建对象
            //    Show();
            //}
            Console.WriteLine("--------多线程---享元模式---池化资源管理---------");
            {
                //有没有办法，既能对象复用，又不破坏封装？
                //1、统一入口---想控制全局的东西
                //2、添加重用逻辑，静态字典缓存一下

                for (int i = 0; i < 5; i++)
                {
                    Task.Run(() =>//近乎于同时启动5个线程完成计算
                    {
                        BaseWord e1 = FlyweightFactory.CreateWord(WordType.E);
                        BaseWord l = FlyweightFactory.CreateWord(WordType.L);
                        //BaseWord e2 = FlyweightFactory.CreateWord(WordType.E);
                        BaseWord v = FlyweightFactory.CreateWord(WordType.V);
                        //BaseWord e3 = FlyweightFactory.CreateWord(WordType.E);
                        BaseWord n = FlyweightFactory.CreateWord(WordType.N);
                        Console.WriteLine("多线程---{0}{1}{2}{3}{4}{5}", e1.Get(), l.Get(), e1.Get(), v.Get(), e1.Get(), n.Get());
                    });
                    //1、5个线程同时执行，字典为空，所以会同时构造5测字母E
                    //2、最后只打印了一个Eleven，因为其他线程挂掉了--因为字典添加相同键时异常了
                    //3、2个L属于小概率事件，前两个线程是同时添加E，所以都没有识别，所以L两个，但是到了L，又冲突了
                    //4、异常我怎么没有看到？子线程的异常是获取不到的，除非waitall，主线程获取。
                }
                //享元模式：为了解决对象的复用问题，提供第三方的管理，能完成对象的复用
                //1、还可以自行实例化对象，不像单例是强制保证的
                //2、池化资源管理：享元工厂也可以初始化多个对象---其它地方需要使用对象可以找我拿(修改状态，表示这个对象被占用了)---用完之后在放回来(状态改回来)---可以避免重复的创建和销毁对象，尤其是对于非托管资源---池化资源管理
                //BaseWord e1 = FlyweightFactory.CreateWord(WordType.E);
                //BaseWord e2 = new E();
                //BaseWord e3 = new E();
                //BaseWord e4 = FlyweightFactory.CreateWord(WordType.E);
                //Console.WriteLine($"{object.ReferenceEquals(e1, e2)}");//false
                //Console.WriteLine($"{object.ReferenceEquals(e1, e3)}");//false
                //Console.WriteLine($"{object.ReferenceEquals(e1, e4)}");//true
            }
            Console.WriteLine("------------C#内存分配探讨-------------");
            {
                BaseWord e1 = FlyweightFactory.CreateWord(WordType.E);
                BaseWord e2 = new E();
                BaseWord e3 = new E();
                BaseWord e4 = FlyweightFactory.CreateWord(WordType.E);
                Console.WriteLine($"C#内存分配探讨---{object.ReferenceEquals(e1, e2)}");//false
                Console.WriteLine($"C#内存分配探讨---{object.ReferenceEquals(e1, e3)}");//false
                Console.WriteLine($"C#内存分配探讨---{object.ReferenceEquals(e1, e4)}");//true
                //e属于引用类型，new个对象等于去内存开辟一块儿空间，变量保存的是个引用，指向该内存。object.ReferenceEquals专门比较引用地址

                //------------考题开始------------

                //第一题
                string teacherOpen = "Eleven";
                string teacherVip= "Eleven";
                Console.WriteLine($"C#内存分配探讨(第一题)---object.ReferenceEquals(teacherOpen, teacherVip)---{object.ReferenceEquals(teacherOpen, teacherVip)}");//true
                Console.WriteLine($"C#内存分配探讨(第一题)---object.ReferenceEquals(teacherOpen, new OtherClass().teacherOther)---{object.ReferenceEquals(teacherOpen, new OtherClass().teacherOther)}");//true
                //第一题答案：true/true; string类型在内存分配时，使用了享元模式，所以是true。
                //只要是同一个进程，分配Eleven都是同一个内存地址的。

                //第二题：
                string teacherFormat = string.Format("Ele{0}","ven");
                string lastPart = "ven";
                string teacherCombination = "Ele" + lastPart;
                Console.WriteLine($"C#内存分配探讨(第二题)---object.ReferenceEquals(teacherOpen, teacherFormat){object.ReferenceEquals(teacherOpen, teacherFormat)}");
                Console.WriteLine($"C#内存分配探讨(第二题)---object.ReferenceEquals(teacherOpen, teacherCombination){object.ReferenceEquals(teacherOpen, teacherCombination)}");
                Console.WriteLine($"C#内存分配探讨(第二题)---object.ReferenceEquals(teacherFormat, teacherCombination){object.ReferenceEquals(teacherFormat, teacherCombination)}");
            }
        }

        public static void Show()
        {
            //准备打印个Eleven
            BaseWord e1 = FlyweightFactory.CreateWord(WordType.E);
            BaseWord l = FlyweightFactory.CreateWord(WordType.L);
            //BaseWord e2 = FlyweightFactory.CreateWord(WordType.E);
            BaseWord v = FlyweightFactory.CreateWord(WordType.V);
            //BaseWord e3 = FlyweightFactory.CreateWord(WordType.E);
            BaseWord n = FlyweightFactory.CreateWord(WordType.N);
            Console.WriteLine("{0}{1}{2}{3}{4}{5}", e1.Get(), l.Get(), e1.Get(), v.Get(), e1.Get(), n.Get());
        }
    }
}
