using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._18迭代器模式.Menu
{
    public interface IIterator<T>
    {
        /// <summary>
        /// 当前值
        /// </summary>
        T Current { get; }
        /// <summary>
        /// 判断是否还有下一个
        /// </summary>
        /// <returns></returns>
        bool MoveNext();
        /// <summary>
        /// 重置
        /// </summary>
        void Reset();
    }
}
