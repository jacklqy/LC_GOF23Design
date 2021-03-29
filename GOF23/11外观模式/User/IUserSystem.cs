using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._11外观模式.User
{
    /// <summary>
    /// 用户接口
    /// </summary>
    public interface IUserSystem
    {
        public bool CheckUser(int id);
    }
}
