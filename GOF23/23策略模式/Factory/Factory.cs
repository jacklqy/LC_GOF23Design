using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GOF23._23策略模式
{
    /// <summary>
    /// 面向对象语音开发从来不担心代码多，因为可以封装一下
    /// 工厂只是转移了矛盾，并没有解决矛盾。
    /// 
    /// 代码升级跟下象棋是一样的，高手其实就是看的远，能看到3步4步
    /// 代码的升级也是一步一步来的，先升级在解决问题，先解决眼前的问题，在解决下一步的问题。
    /// </summary>
    public class Factory
    {
        /// <summary>
        /// 1、简单工厂只是转移了矛盾，并没有解决矛盾。(类的单一职责、迪米特法则)
        /// </summary>
        /// <param name="operate"></param>
        /// <returns></returns>
        public static ICaculation GetCaculation(string operate)
        {
            ICaculation iCaculation = null;
            switch (operate)
            {
                case "+":
                    iCaculation = new Plus();
                    break;
                case "-":
                    iCaculation = new Minus();
                    break;
                case "*":
                    iCaculation = new Mutiply();
                    break;
                case "/":
                    iCaculation = new Devision();
                    break;
                default:
                    throw new Exception("wrong operate");
            }
            return iCaculation;
        }

        /// <summary>
        /// 2、通过反射的方式
        /// 不仅把对象创建给屏蔽了，而且映射关系也可以配置文件决定了
        /// </summary>
        /// <param name="operate"></param>
        /// <returns></returns>
        public static ICaculation GetCaculationReflection(string operate)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsetting.json", optional: true, reloadOnChange: false)
                .Build();
            var className = config[$"ICaculation{operate}"].Split(',')[0];
            var dllName = config[$"ICaculation{operate}"].Split(',')[1];
            Assembly assembly = Assembly.Load(dllName);
            Type type = assembly.GetType(className);
            return (ICaculation)Activator.CreateInstance(type);
        }

        //3、单独写一个类库，里面增加一个类实现ICaculation接口，然后将这个类库编译后的dll文件拷贝到当前项目的bin目录下，然后修改配置文件的里面的通过反射调用的值，就可以做到无缝扩展效果。
    }
}
