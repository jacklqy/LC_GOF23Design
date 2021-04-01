using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._17命令模式
{
    /// <summary>
    /// 命令执行者1
    /// </summary>
    public class Receiver1 : IReceiver
    {
        public void Read()
        {
            Console.WriteLine("Read1");
        }

        public void Write()
        {
            Console.WriteLine("Write1");
        }

        public void Save()
        {
            Console.WriteLine("Save1");
        }
    }

}
