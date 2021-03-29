using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._11外观模式.Storage
{
    /// <summary>
    /// 仓储接口
    /// </summary>
    public interface IStorageSystem
    {
        public bool CheckStorage(int productId);
    }
}
