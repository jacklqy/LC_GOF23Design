using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._17命令模式
{
    /// <summary>
    /// 命令的调用者
    /// </summary>
    public class Invoker
    {
        private BaseCommand _BaseCommand = null;//可以换成多个命令的集合，整合命令批量执行命令。

        public Invoker(BaseCommand baseCommand)
        {
            this._BaseCommand = baseCommand;
        }
        public void Excute()
        {
            this._BaseCommand.Excute();
        }
    }
}
