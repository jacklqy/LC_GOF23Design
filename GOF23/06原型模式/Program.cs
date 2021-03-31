﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._06原型模式
{
    /// <summary>
    /// 单列模式/原型模式/享元模式
    /// 浅克隆VS深克隆，原型模式的应用。C#内存分配机制详析
    /// 
    /// 意图：用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象。
    /// 主要解决：在运行期建立和删除原型。
    /// 何时使用： 
    ///     1、当一个系统应该独立于它的产品创建，构成和表示时。 
    ///     2、当要实例化的类是在运行时刻指定时，例如，通过动态装载。 
    ///     3、为了避免创建一个与产品类层次平行的工厂类层次时。 
    ///     4、当一个类的实例只能有几个不同状态组合中的一种时。建立相应数目的原型并克隆它们可能比每次用合适的状态手工实例化该类更方便一些。
    /// 如何解决：利用已有的一个原型对象，快速地生成和原型对象一样的实例。
    /// 使用场景： 
    ///     1、资源优化场景。 (比如画象棋格子，先初始化一个对象，后面批量clone许多格子对象，然后在根据业务场景对这些格子对象分别设置不同的属性值。)
    ///     2、类初始化需要消化非常多的资源，这个资源包括数据、硬件资源等。 
    ///     3、性能和安全要求的场景。 
    ///     4、通过 new 产生一个对象需要非常繁琐的数据准备或访问权限，则可以使用原型模式。 
    ///     5、一个对象多个修改者的场景。 
    ///     6、一个对象需要提供给其他对象访问，而且各个调用者可能都需要修改其值时，可以考虑使用原型模式拷贝多个对象供调用者使用。 
    ///     7、在实际项目中，原型模式很少单独出现，一般是和工厂方法模式一起出现，通过 clone 的方法创建一个对象，然后由工厂方法提供给调用者。原型模式已经与 Java 融为浑然一体，大家可以随手拿来使用。
    /// 优点： 
    ///     1、性能提高。 
    ///     2、逃避构造函数的约束。
    /// 缺点： 
    ///     1、配备克隆方法需要对类的功能进行通盘考虑，这对于全新的类不是很难，但对于已有的类不一定很容易，特别当一个类引用不支持串行化的间接对象，或者引用含有循环结构的时候。
    ///     2、必须实现 Cloneable 接口。
    /// </summary>
    public class Program : OpentDesign
    {
        public override void Open()
        {
            Console.WriteLine("****************原型模式******************");

            try
            {
                //对象复用--循环的最简单--不同的方法/类/线程/类库重用对象怎么解决？
                {
                    //Student student = new Student()
                    //{
                    //    Id = 123,
                    //    Name = "犀利哥"
                    //};
                    //for (int i = 0; i < 5; i++)
                    //{
                    //    //Student student = new Student()
                    //    //{
                    //    //    Id = 123,
                    //    //    Name = "犀利哥"
                    //    //};
                    //    student.Study();
                    //}
                }

                //{
                //    Console.WriteLine("*********************单例模式******************");
                //    for (int i = 0; i < 5; i++)
                //    {
                //        StudentSingleton studentSingleton1 = StudentSingleton.GetInstance();
                //        StudentSingleton studentSingleton2 = StudentSingleton.GetInstance();

                //        studentSingleton1.Id = 234;
                //        studentSingleton1.Name = "修改名称1";

                //        studentSingleton2.Id = 345;
                //        studentSingleton2.Name = "修改名称2";

                //        studentSingleton1.Study();
                //        studentSingleton2.Study();
                //        //单列---整个进程只有一个实例--能出现两个学生吗？不可能！---后面的修改会覆盖前面的修改值
                //    }
                //}

                Console.WriteLine("*******************浅拷贝*******************");
                {
                    //单列可以对象复用----但是会出现覆盖
                    //能不能不覆盖，但是性能也高？
                    Console.WriteLine("*********************原型模式******************");
                    StudentPrototype studentPrototype1 = StudentPrototype.GetInstance();
                    StudentPrototype studentPrototype2 = StudentPrototype.GetInstance();
                    StudentPrototype studentPrototype3 = StudentPrototype.GetInstance();

                    studentPrototype1.Id = 111;
                    studentPrototype1.Name = "修改名称111";
                    studentPrototype1.book.BookId = 111;
                    studentPrototype1.book.BookName = "book111";

                    studentPrototype2.Id = 222;
                    studentPrototype2.Name = "修改名称222";
                    studentPrototype2.book.BookId = 222;
                    studentPrototype2.book.BookName = "book222";

                    studentPrototype3.Id = 333;
                    studentPrototype3.Name = "修改名称333";
                    studentPrototype3.book = new Book()
                    {
                        BookId = 333,
                        BookName = "book333"
                    };

                    studentPrototype1.Study();
                    studentPrototype2.Study();
                    studentPrototype3.Study();

                    ///输出结果BookId 222/222/333  C#内存分配
                    ///StudentPrototype.Study被调用啦.Id = 111 Name = 修改名称111 BookId = 222 BookName = book222
                    ///StudentPrototype.Study被调用啦.Id = 222 Name = 修改名称222 BookId = 222 BookName = book222
                    ///StudentPrototype.Study被调用啦.Id = 333 Name = 修改名称333 BookId = 333 BookName = book333

                    ///Name 因为string类型的 ="codeman" 等同于new string("codeman")，开辟新空间，不影响之前的值---实际上string是不可修改的---（因为string不可修改才可以享元模式）

                }

                {
                    ///不理解引用类型和值类型区别的程序员将会给代码引入诡异的bug和性能问题
                    ///C#内存分配 进程堆(进程唯一) 线程栈(每个线程一个)
                    ///引用类型在堆里，值类型在栈里---变量是值还是引用仅取决于其数据类型。注意：简单地说“值类型存储在栈上，引用类型存储在托管堆上”是不对的。必须具体情况具体分析。比如类型嵌套。
                    ///引用类型对象里面的值类型----studentPrototype1.Id是存储在堆还是栈？在堆里
                    ///值类型里面的引用类型----Customer.Name是存储在堆还是栈？在堆里(任何引用类型的值都在堆里)
                    ///
                    ///***值类型***
                    ///整 型：sbyte（System.SByte的别名），short（System.Int16），int（System.Int32），long （System.Int64），byte（System.Byte），ushort（System.UInt16），uint （System.UInt32），ulong（System.UInt64），char（System.Char）；
                    ///浮点型：float（System.Single），double（System.Double）；
                    ///用于财务计算的高精度decimal型：decimal（System.Decimal）。
                    ///bool型：bool（System.Boolean的别名）；
                    ///结构体：struct
                    ///枚举：enum
                    ///C#的所有值类型均隐式派生自System.ValueType
                    ///int i = new int();等价于Int32 i = new Int32();等价于int i = 0;等价于Int32 i = 0;
                    ///值得注意的是，System.ValueType直接派生于System.Object。即System.ValueType本身是一个类类型，而不是值类型。其关键在于ValueType重写了Equals()方法，从而对值类型按照实例的值来比较，而不是引用地址来比较。
                    ///可以用Type.IsValueType属性来判断一个类型是否为值类型。
                    ///所有的值类型都是密封（seal）的，所以无法派生出新的值类型。
                    ///
                    ///***引用类型***
                    ///数组/类/接口/委托/object/字符串
                    ///


                }

                Console.WriteLine("*******************深拷贝*******************");
                {
                    StudentPrototype studentPrototype1 = StudentPrototype.GetInstanceSerializ();
                    StudentPrototype studentPrototype2 = StudentPrototype.GetInstanceSerializ();
                    studentPrototype1.Id = 111;
                    studentPrototype1.Name = "修改名称111";
                    studentPrototype1.book.BookId = 111;
                    studentPrototype1.book.BookName = "book111";

                    studentPrototype2.Id = 222;
                    studentPrototype2.Name = "修改名称222";
                    studentPrototype2.book.BookId = 222;
                    studentPrototype2.book.BookName = "book222";

                    studentPrototype1.Study();
                    studentPrototype2.Study();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public struct Customer
        {
            public string Name;
        }
    }
}
