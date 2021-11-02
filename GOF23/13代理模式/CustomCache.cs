using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._13代理模式
{
    /// <summary>
    /// 第三方存储---保证数据不丢失--可以放进来--可以获取--缓存
    /// 未考虑多线程、缓存失效
    /// </summary>
    public class CustomCache
    {
        private static Dictionary<string, object> CustomCacheDictionary = new Dictionary<string, object>();//可考虑用线程安全字典
        public static void Add(string key,object oValue)
        {
            CustomCacheDictionary.Add(key, oValue);
        }
        public static T Get<T>(string key)
        {
            return (T)CustomCacheDictionary[key];
        }

        public static bool Exists(string key)
        {
            return CustomCacheDictionary.ContainsKey(key);
        }
    }
}
