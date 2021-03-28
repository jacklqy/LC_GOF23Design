﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._08桥接模式
{
    /// <summary>
    /// Winphone手机
    /// </summary>
    public class LumiaBridge : BasePhoneBridge
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
        //    return "Winphone";
        //}

        //public override string Version()
        //{
        //    return "10.0";
        //}
    }
}
