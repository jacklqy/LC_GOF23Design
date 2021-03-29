using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._08桥接模式
{
    /// <summary>
    /// Android手机
    /// </summary>
    public class WinphoneSystem : ISystem
    {
        public string System()
        {
            return "Winphone";
        }

        public string Version()
        {
            return "10.0";
        }
    }
}
