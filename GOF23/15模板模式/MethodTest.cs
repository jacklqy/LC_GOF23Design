using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._15模板模式
{
    /// <summary>
    /// 知识同步：普通方法 虚方法 抽象方法
    /// </summary>
    public class MethodTest
    {
        //-------------------------知识点同步------------------------
        //值类型(栈)和引用类型(堆)
        //堆栈-》内存分配机制-》垃圾回收机制

        //const和static readonly的确很像：通过类名而不是对象名进行访问，在程序中只读等等。在多数情况下可以混用。
        //二者本质的区别在于，const的值是在编译期间确定的，因此只能在声明时通过常量表达式指定其值。而static readonly是在运行时计算出其值的，所以还可以通过静态构造函数来赋值。
        //编译时决定const、普通方法子类复写new父类方法/运行时决定readonly、static

        //public 公共的，访问权限最高的。
        //private 私有的，访问权限最低，仅在类内部。
        //protected 类及其子类可以访问
        //internal 同一个程序集可以访问
        //protected internal internal和protected的交集，同一个程序集内部 以及 不同程序集但存在继承关系的可以引用。

        //抽象方法abstract、虚方法virtual、普通方法new

        //只读属性get，只能在类初始化调用构造函数时对只读属性进行赋值或者给指定属性设置初始默认值。

        // C#中字段和属性的区别
        //字段的使用场景：与类或者对象关系密切，建议使用private修饰。
        //属性的使用场景：对字段进行封装，提供get/set关键字，进行访问。
        //变量的使用场景：与类或者对象关系不密切，常常在方法或者语句块中使用。
        //字段和属性是相对于类而言的，而变量相对于方法或者语句块而言，可以再任何地方使用。

        //字段和变量的区别：直接在类中的数据成员为字段，他用访问修饰符和数据类型类定义（public string name；），字段就像类的一个小数据库，用来存放与类相关的数据；而单纯的变量是没有修饰符的（int age；），他不能直接在类里面定义，只能在函数里面定义，他用来作为方法的一个临时变量。

        //-------------------------知识点同步------------------------
        public static void Show()
        {
            //ParentClass parentClass = new ParentClass();//抽象类不能直接实例化

            Console.WriteLine("******************抽象方法*****************");
            {
                Console.WriteLine("ParentClass abstractTest1 = new ChildClass();");
                ParentClass abstractTest1 = new ChildClass();
                //抽象/虚 方法的调用，是运行时决定的，也就是右边决定的
                abstractTest1.Show();//调用子类方法 ****注意***

                Console.WriteLine("ChildClass abstractTest2 = new ChildClass();");
                ChildClass abstractTest2 = new ChildClass();
                abstractTest2.Show();//调用子类方法
            }

            Console.WriteLine("******************普通方法*****************");
            {
                Console.WriteLine("NewTest newTest1 = new NewTest();");
                NewTest newTest1 = new NewTest();
                newTest1.Show();//调用父类方法

                Console.WriteLine("NewTest newTest2 = new NewTestChild();");
                NewTest newTest2 = new NewTestChild();
                //普通方法的调用，是编译时决定的，也就是左边决定的
                newTest2.Show();//调用父类方法 ****注意****

                Console.WriteLine("NewTestChild newTest3 = new NewTestChild();");
                NewTestChild newTest3 = new NewTestChild();
                newTest3.Show();//调用子类方法
            }

            Console.WriteLine("******************虚方法*****************");
            {
                Console.WriteLine("VirtualTest virtualTest1 = new VirtualTest();");
                VirtualTest virtualTest1 = new VirtualTest();
                virtualTest1.Show();//调用父类方法

                Console.WriteLine("VirtualTest virtualTest2 = new VirtualTestChild();");
                VirtualTest virtualTest2 = new VirtualTestChild();
                //抽象/虚 方法的调用，是运行时决定的，也就是右边决定的
                virtualTest2.Show();//调用子类方法 ****注意***

                Console.WriteLine("VirtualTest virtualTest2 = new VirtualTestChild();");
                VirtualTestChild virtualTest3 = new VirtualTestChild();
                virtualTest3.Show();//调用子类方法
            }
        }
    }

    #region Abstract 抽象方法
    public abstract class ParentClass
    {
        /// <summary>
        /// 抽象方法
        /// </summary>
        public abstract void Show();
    }

    public class ChildClass : ParentClass
    {
        /// <summary>
        /// virtual
        /// </summary>
        public override void Show()
        {
            Console.WriteLine("this is {0}", this.GetType().Name);
        }
    }
    #endregion

    #region New 普通方法
    public class NewTest
    {
        public void Show()
        {
            Console.WriteLine("this is 2222 {0}", this.GetType().Name);
        }
    }
    public class NewTestChild : NewTest
    {
        /// <summary>
        /// new 要不要都没有区别 都会隐藏掉父类方法
        /// 不要new会提示警告
        /// </summary>
        public new void Show() //隐藏
        {
            Console.WriteLine("this is 11111 {0}", this.GetType().Name);
        }
    }
    #endregion

    #region Virtual 虚方法
    public class VirtualTest
    {
        /// <summary>
        /// virtual 虚方法必须包含实现，但是可以被覆写
        /// </summary>
        public virtual void Show()
        {
            Console.WriteLine("this is {0}", this.GetType().Name);
        }
    }
    public class VirtualTestChild : VirtualTest
    {
        /// <summary>
        /// 可以覆写，也可以不覆写
        /// </summary>
        public override void Show()
        {
            Console.WriteLine("this is {0}", this.GetType().Name);
        }
    } 
    #endregion
}
