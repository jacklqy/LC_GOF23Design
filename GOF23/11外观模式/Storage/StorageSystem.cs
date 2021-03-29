using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._11外观模式.Storage
{
    /// <summary>
    /// 仓储
    /// </summary>
    public class StorageSystem : IStorageSystem
    {
        public bool CheckStorage(int productId)
        {
            return true;
        }
    }
}
