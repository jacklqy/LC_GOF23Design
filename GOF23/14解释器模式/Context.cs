using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._14解释器模式
{
    /// <summary>
    /// 上下文，保存请求处理过程中的所有信息
    /// (常见HttpContext/DBContext 这些都是包含请求的所有信息)
    /// </summary>
    public class Context
    {
        private string _word = null;
        public Context(string word)
        {
            this._word = word;
        }

        public void Set(string newWord)
        {
            this._word = newWord;
        }

        public string Get()
        {
            return this._word;
        }
    }
}
