using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._08桥接模式
{
    /// <summary>
    /// Android手机
    /// </summary>
    public class GalaxyBridge : BasePhoneBridge
    {
        public override void Call()
        {
            Console.WriteLine("Use OS {0}.{1}.{2} Call", this.GetType().Name, base.SystemVersion.System(), base.SystemVersion.Version());
        }


        public override void Text()
        {
            Console.WriteLine("Use OS {0}.{1}.{2} Text", this.GetType().Name, base.SystemVersion.System(), base.SystemVersion.Version());
        }

        //public override string System()
        //{
        //    return "Android";
        //}

        //public override string Version()
        //{
        //    return "5.0";
        //}
    }
}
