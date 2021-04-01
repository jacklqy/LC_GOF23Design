using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._17命令模式
{
    /// <summary>
    /// 保存命令
    /// </summary>
    public class SaveCommand : BaseCommand
    {
        public override void Excute()
        {
            //Console.WriteLine("Save");
            //将行为转移，把命令和命令执行者分开
            base._Receiver.Save();
        }
    }
}
