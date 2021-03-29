using GOF23._06原型模式.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GOF23._06原型模式
{
    /// <summary>
    /// 原型类
    /// </summary>
    [Serializable]
    public class StudentPrototype
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Book book { get; set; }

        /// <summary>
        /// 1、私有化构造函数
        /// </summary>
        private StudentPrototype()
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
        private static StudentPrototype _StudentSingleton = new StudentPrototype()
        {
            Id = 0,
            Name = "犀利哥",
            book = new Book()
            {
                BookId = 0,
                BookName = "十万个为什么？"
            }
        };

        /// <summary>
        /// 3、公开静态方法来提供实例
        /// </summary>
        /// <returns></returns>
        public static StudentPrototype GetInstance()
        {
            //MemberwiseClone：内存拷贝，不走构造函数，直接内存copy，所以没有性能损失。而且产生的是一个全新的对象
            //MemberwiseClone：浅拷贝，只拷贝引用
            StudentPrototype student = (StudentPrototype)_StudentSingleton.MemberwiseClone();

            //把引用地址重新赋值，完成了深拷贝---不仅拷贝引用，还的拷贝引用类型的值
            //麻烦？晚点还有答案
            //student.book = new Book()
            //{
            //    BookId = student.book.BookId,
            //    BookName = student.book.BookName
            //};
            return student;
        }

        //深拷贝：1直接new 2子类型提供原型方式 3序列化和反序列化
        /// <summary>
        /// 深拷贝：通过序列化和反序列化实现深拷贝（利用.net框架的二进制序列化器）
        /// </summary>
        /// <returns></returns>
        public static StudentPrototype GetInstanceSerializ()
        {
            return SerializeHelper.DeepClone<StudentPrototype>(_StudentSingleton);
        }

        public void Study()
        {
            Console.WriteLine("{0}.{1}被调用啦.Id={2} Name={3} BookId={4} BookName={5}", this.GetType().Name, "Study", this.Id, this.Name, this.book.BookId, this.book.BookName);
        }
    }

    [Serializable]
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
    }
}
