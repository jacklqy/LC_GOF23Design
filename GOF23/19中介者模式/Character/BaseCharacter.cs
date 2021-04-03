using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._19中介者模式.Character
{
    public abstract class BaseCharacter
    {
        public string Name { get; set; }
        public abstract void SendMessage(string message, BaseCharacter characterTo);
        public abstract void GetMessage(string message, BaseCharacter characterFrom);
    }
}
