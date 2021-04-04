using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._23策略模式
{
    /// <summary>
    /// 计算接口
    /// </summary>
    public interface ICaculation
    {
        public int Caculation(int iInputLeft, int iInputRight);
    }
}
