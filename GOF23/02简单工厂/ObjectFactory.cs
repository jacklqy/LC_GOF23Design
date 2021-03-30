using GOF23._02简单工厂.Interface;
using GOF23._02简单工厂.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace GOF23._02简单工厂
{
    /// <summary>
    /// 简单工厂类
    /// </summary>
    public class ObjectFactory
    {
        private static string _ReacType = null;
        private static string _ReacTypeReflection = null;
        /// <summary>
        /// 静态构造函数：由CLR保证，在第一次使用这个类之前，自动被调用且只调用一次.
        /// </summary>
        static ObjectFactory()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsetting.json", optional: true, reloadOnChange: false)
                .Build();
            _ReacType = config["IReacType"];
            _ReacTypeReflection = config["IReacTypeReflection"];
        }
        /// <summary>
        /// 1、根据传入的枚举类型创建对象
        /// </summary>
        /// <param name="reacType">枚举类型</param>
        /// <returns></returns>
        public static IRace CreateInstance(ReacType reacType)
        {
            IRace iRace = null;
            switch (reacType)
            {
                case ReacType.Human:
                    iRace = new Human();
                    break;
                case ReacType.NE:
                    iRace = new NE();
                    break;
                case ReacType.ORC:
                    iRace = new ORC();
                    break;
                case ReacType.Undead:
                    iRace = new Undead();
                    break;
                default:
                    throw new Exception("Wrong reacType");
            }
            return iRace;
        }

        /// <summary>
        /// 2、从配置文件读取要创建的对象
        /// </summary>
        /// <returns></returns>
        public static IRace CreateInstanceConfig()
        {
            ReacType reacType =   (ReacType)Enum.Parse(typeof(ReacType), _ReacType);
            return CreateInstance(reacType);
        }

        /// <summary>
        ////3、通过反射的方式创建对象
        /// </summary>
        /// <returns></returns>
        public static IRace CreateInstanceConfigReflection()
        {
            //从配置文件读取类全名称
            var className = _ReacTypeReflection.Split(',')[0];
            //从配置文件读取dll全名称
            var dllName = _ReacTypeReflection.Split(',')[1];
            Assembly assembly = Assembly.Load(dllName);
            Type type = assembly.GetType(className);
            return (IRace)Activator.CreateInstance(type);
        }

        //4、单独写一个类库，里面增加一个类实现IRace接口，然后将这个类库编译后的dll文件拷贝到当前项目的bin目录下，然后修改配置文件的里面的通过反射调用的值，就可以做到无缝扩展效果。
        //todo...


        public enum ReacType
        {
            Human,
            NE,
            ORC,
            Undead
        }
    }
}
