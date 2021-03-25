using GOF23._05建造者模式.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._05建造者模式
{
    /// <summary>
    /// 比亚迪工人
    /// </summary>
    public class BuilderBYD: AbstractBuilder
    {
        //引擎对象类
        private Engine _Engine = null;
        //轮子对象类
        private Wheels _Wheels = null;
        //灯对象类
        private Light _Light = null;
        /// <summary>
        /// 引擎
        /// </summary>
        public override void Engine()
        {
            _Engine = new Engine("_Engine");
            Console.WriteLine("{0}：build Engine", this.GetType().Name);
        }
        /// <summary>
        /// 轮子
        /// </summary>
        public override void Wheels()
        {
            _Wheels = new Wheels("_Wheels");
            Console.WriteLine("{0}：build Wheels", this.GetType().Name);
        }
        /// <summary>
        /// 灯
        /// </summary>
        public override void Light()
        {
            _Light = new Light("_Light");
            Console.WriteLine("{0}：build Light", this.GetType().Name);
        }


        /// <summary>
        /// 造车
        /// </summary>
        public override Car Car()
        {
            Console.WriteLine("{0}：build Car", this.GetType().Name);
            return new Car(this._Engine, this._Wheels, this._Light)
            {
                Name = "比亚迪[唐]"
            };
        }
    }
}
