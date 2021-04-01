using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._17命令模式
{
    /// <summary>
    /// 命令执行者抽象
    /// </summary>
    public interface IReceiver
    {
        public void Read();
        public void Write();
        public void Save();
    }
}
