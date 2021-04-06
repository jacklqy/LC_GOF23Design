using GOF23._02简单工厂.Interface;
using GOF23._02简单工厂.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._02简单工厂
{
    /// <summary>
    /// 玩家
    /// </summary>
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 方法注入灵活/构造函数注入只有在初始化是才可以，比较局限。/成员变量注入一开始就固定了。
        /// </summary>
        /// <param name="iRace"></param>
        public void Play(IRace iRace)//方法注入(方法注入、构造函数注入、成员变量注入)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("This is {0} Play War3.{1}", this.Name, iRace.GetType().Name);
            iRace.ShowKing();
        }

        //public void PlayHuman(Human human)
        //{
        //    Console.WriteLine("***********************");
        //    Console.WriteLine("This is {0} Play War3.{1}", this.Name, human.GetType().Name);
        //    human.ShowKing();
        //}
        //public void PlayNE(NE nE)
        //{
        //    Console.WriteLine("***********************");
        //    Console.WriteLine("This is {0} Play War3.{1}", this.Name, nE.GetType().Name);
        //    nE.ShowKing();
        //}
    }
}
