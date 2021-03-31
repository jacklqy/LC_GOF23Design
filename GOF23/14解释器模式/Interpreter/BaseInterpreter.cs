using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOF23._14解释器模式
{
    /// <summary>
    /// 抽象解释器
    /// </summary>
    public abstract class BaseInterpreter
    {
        /// <summary>
        /// 转换
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public abstract void Conversion(Context context);
    }
}
