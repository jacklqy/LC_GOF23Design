using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._19中介者模式.Character
{
    /// <summary>
    /// 学员
    /// </summary>
    public class Student : BaseCharacter
    {
        public override void SendMessage(string message, BaseCharacter characterTo)
        {
            Console.WriteLine("{0}学员to {1}：{2}", base.Name, characterTo.Name, message);
            characterTo.GetMessage(message, this);
        }

        public override void GetMessage(string message, BaseCharacter characterFrom)
        {
            Console.WriteLine("{0}学员get {1}：{2}", base.Name, characterFrom.Name, message);
        }
    }
}
