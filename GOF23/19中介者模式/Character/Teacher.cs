using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._19中介者模式.Character
{
    /// <summary>
    /// 老师
    /// </summary>
    public class Teacher : BaseCharacter
    {

        public override void SendMessage(string message, BaseCharacter characterTo)
        {
            Console.WriteLine("{0}老师to {1}:{2}", base.Name, characterTo.Name, message);
            characterTo.GetMessage(message, this);
        }

        public override void GetMessage(string message, BaseCharacter characterFrom)
        {
            Console.WriteLine("{0}老师get {1}：{2}", base.Name, characterFrom.Name, message);
        }
    }
}
