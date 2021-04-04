using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._23策略模式
{
    /// <summary>
    /// 减
    /// </summary>
    public class Minus : ICaculation
    {
        public int Caculation(int iInputLeft, int iInputRight)
        {
            return iInputLeft - iInputRight;
        }
    }
}
