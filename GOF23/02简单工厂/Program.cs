using GOF23._02简单工厂.Interface;
using GOF23._02简单工厂.Service;
using System;
using System.Collections.Generic;
using System.Text;
using static GOF23._02简单工厂.ObjectFactory;

namespace GOF23._02简单工厂
{
    /// <summary>
    /// 优点：去掉高层对细节的依赖，保证了高层的稳定
    /// 缺点：没有消除矛盾，只是转移了矛盾，甚至还集中了矛盾
    /// </summary>
    public class Program : OpentDesign
    {
        public override void Open()
        {
            Player player = new Player();

            //1、根据枚举值创建对象
            IRace human = ObjectFactory.CreateInstance(ReacType.Human);
            player.Play(human);
            
            //2、从配置文件获取创建对象
            IRace human2 = ObjectFactory.CreateInstanceConfig();
            player.Play(human2);


            //{
            //    IRace human = new Human();
            //    player.Play(human);
            //}
            //{
            //    IRace nE = new NE();
            //    player.Play(nE);
            //}
            //{
            //    IRace oRC = new ORC();
            //    player.Play(oRC);
            //}
            //{
            //    IRace undead = new Undead();
            //    player.Play(undead);
            //}
        }
    }
}
