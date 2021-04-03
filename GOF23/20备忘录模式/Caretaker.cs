using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._20备忘录模式
{
    /// <summary>
    /// 守护者：第三方存储容器（txt/xml/db/缓存/内存）
    /// </summary>
    public class Caretaker
    {
        //private static War3Memento _War3Memento = null;
        //public static void SaveWar3Memento(War3Memento war3Memento)
        //{
        //    _War3Memento = war3Memento;
        //}

        //public static War3Memento GetWar3Memento()
        //{
        //    return _War3Memento;
        //}

        //可以存放在Redis/db/xml等...
        private static Dictionary<string, War3Memento> _War3MementoDictionary = new Dictionary<string, War3Memento>();
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="name">版本名称</param>
        /// <param name="war3Memento"></param>
        public static void SaveWar3Memento(string name, War3Memento war3Memento)
        {
            if (!_War3MementoDictionary.ContainsKey(name))
                _War3MementoDictionary.Add(name, war3Memento);
            else
                throw new Exception("wrong name");
        }
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="name">版本名称</param>
        /// <returns></returns>
        public static War3Memento GetWar3Memento(string name)
        {
            if (_War3MementoDictionary.ContainsKey(name))
                return _War3MementoDictionary[name];
            else
                throw new Exception("wrong name");
        }
    }
}
