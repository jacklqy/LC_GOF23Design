using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._08桥接模式
{
    /// <summary>
    /// Android手机
    /// </summary>
    public class IOSSystem : ISystem
    {
        public string System()
        {
            return "IOS";
        }

        public string Version()
        {
            return "9.3";
        }
    }
}
