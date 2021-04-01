using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._17命令模式
{
    /// <summary>
    /// 命令执行者2
    /// </summary>
    public class Receiver2 : IReceiver
    {
        public void Read()
        {
            Console.WriteLine("Read2");
        }

        public void Write()
        {
            Console.WriteLine("Write2");
        }

        public void Save()
        {
            Console.WriteLine("Save2");
        }
    }
}
