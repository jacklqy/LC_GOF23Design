using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._17命令模式
{
    /// <summary>
    /// 命令抽象
    /// </summary>
    public abstract class BaseCommand
    {
        public Document _Document
        {
            get;
            private set;
        }
        public IReceiver _Receiver
        {
            get;
            private set;
        }
        public void Set(Document document)
        {
            this._Document = document;
        }

        public void SetReceiver(IReceiver receiver)
        {
            this._Receiver = receiver;
        }

        public abstract void Excute();
    }
}
