using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._13代理模式
{
    public interface ISubject
    {
        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public List<string> GetSomethingLong();
        /// <summary>
        /// Do
        /// </summary>
        public void DoSomethingLong();
    }
}
