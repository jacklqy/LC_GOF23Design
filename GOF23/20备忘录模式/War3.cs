using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._20备忘录模式
{
    /// <summary>
    /// 魔兽争霸
    /// </summary>
    public class War3
    {
        public string Race { get; set; }
        public string Hero { get; set; }
        public string Army { get; set; }
        public string Resource { get; set; }
        public void Show()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("     Race：{0}", this.Race);
            Console.WriteLine("     Hero：{0}", this.Hero);
            Console.WriteLine("     Army：{0}", this.Army);
            Console.WriteLine("     Resource：{0}", this.Resource);
            Console.WriteLine("*******************************");
        }

        ///// <summary>
        ///// 保存游戏
        ///// </summary>
        //public void Save()
        //{
        //    War3Memento memento = new War3Memento(this.Hero, this.Army, this.Resource);
        //    Caretaker.SaveWar3Memento(memento);
        //}
        ///// <summary>
        ///// 恢复
        ///// </summary>
        //public void Resume()
        //{
        //    War3Memento memento = Caretaker.GetWar3Memento();
        //    this.Hero = memento.Hero;
        //    this.Army = memento.Army;
        //    this.Resource = memento.Resource;
        //}

        /// <summary>
        /// 保存游戏
        /// </summary>
        /// <param name="name">版本号</param>
        public void Save(string name)
        {
            War3Memento memento = new War3Memento(this.Hero, this.Army, this.Resource);
            Caretaker.SaveWar3Memento(name, memento);
        }
        /// <summary>
        /// 恢复游戏
        /// </summary>
        /// <param name="name">版本号</param>
        public void Resume(string name)
        {
            War3Memento memento = Caretaker.GetWar3Memento(name);
            this.Hero = memento.Hero;
            this.Army = memento.Army;
            this.Resource = memento.Resource;
        }
    }
}
