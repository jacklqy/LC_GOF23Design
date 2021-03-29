using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._07适配器模式
{
    /// <summary>
    /// 数据访问接口
    /// </summary>
    public interface IHelper
    {
        void Add<T>();
        void Delete<T>();
        void Update<T>();
        void Query<T>();
    }
}
