using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._08桥接模式
{
    /// <summary>
    /// Android手机
    /// </summary>
    public class AndroidSystem : ISystem
    {
        public string System()
        {
            return "Android";
        }

        public string Version()
        {
            return "5.0";
        }
    }
}
