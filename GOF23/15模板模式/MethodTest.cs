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
