using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._17命令模式
{
    /// <summary>
    /// 读命令
    /// </summary>
    public class ReadCommand : BaseCommand
    {
        public override void Excute()
        {
            //Console.WriteLine("Read");
            //将行为转移，把命令和命令执行者分开
            base._Receiver.Read();
        }
    }
}
