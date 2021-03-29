using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace GOF23._06原型模式.Helper
{
    /// <summary>
    /// 利用.net框架的二进制序列化器，产生一个全新的对象，而且不走构造函数
    /// </summary>
    public class SerializeHelper
    {
        /// <summary>
        /// 将对象序列化为字符串
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string Serializable(object target)
        {
            using (MemoryStream stream=new MemoryStream())
            {
                new BinaryFormatter().Serialize(stream, target);
                return Convert.ToBase64String(stream.ToArray());
            }
        }

        /// <summary>
        /// 将字符串反序列化为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target"></param>
        /// <returns></returns>
        public static T Derializable<T>(string target)
        {
            byte[] targetArray = Convert.FromBase64String(target);
            using (MemoryStream stream=new MemoryStream())
            {
                return (T)(new BinaryFormatter().Deserialize(stream));
            }
        }

        /// <summary>
        /// 深拷贝
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static T DeepClone<T>(T t)
        {
            return Derializable<T>(Serializable(t));
        }
    }
}
