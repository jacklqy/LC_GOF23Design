using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._17命令模式
{
    /// <summary>
    /// 写命令
    /// </summary>
    public class WriteCommand : BaseCommand
    {
        public override void Excute()
        {
            //Console.WriteLine("Write");
            //将行为转移，把命令和命令执行者分开
            base._Receiver.Write();
        }
    }
}
