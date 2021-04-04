using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._23策略模式
{
    /// <summary>
    /// 加
    /// </summary>
    public class Plus : ICaculation
    {
        public int Caculation(int iInputLeft,int iInputRight)
        {
            return iInputLeft + iInputRight;
        }
    }
}
