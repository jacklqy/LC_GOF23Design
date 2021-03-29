using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._11外观模式.User
{
    /// <summary>
    /// 用户
    /// </summary>
    public class UserSystem : IUserSystem
    {
        public bool CheckUser(int id)
        {
            return id > 100;
        }
    }
}
