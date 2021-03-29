using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._11外观模式.Logistics
{
    /// <summary>
    /// 物流接口
    /// </summary>
    public interface ILogisticsSystem
    {
        public bool CheckLogistics(int productId, int cityId);
        public void NewLogistics(int productId, int cityId);
    }
}
