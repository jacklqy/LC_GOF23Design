using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._22状态模式
{
    /// <summary>
    /// 交通灯
    /// </summary>
    public class TrafficLight
    {
        /// <summary>
        /// 0 绿灯 1 黄灯 2 红灯
        /// </summary>
        public LightColor Color { get; set; }
        /// <summary>
        /// 交通信号灯显示  违法单一职责和迪米特法则(简单意味着强大、简单意味着稳定)
        /// </summary>
        public void Show()
        {
            if (this.Color == LightColor.Green)
            {
                Console.WriteLine("绿灯行");
            }
            else if(this.Color==LightColor.Yellow)
            {
                Console.WriteLine("黄灯请小心");
            }
            else if(this.Color==LightColor.Red)
            {
                Console.WriteLine("红灯停");
            }
        }

        /// <summary>
        /// 交通信号灯转换   违法单一职责和迪米特法则(简单意味着强大、简单意味着稳定)
        /// 绿灯-》黄灯
        /// 黄灯-》红灯
        /// 红灯-》绿灯
        /// </summary>
        public void Turn()
        {
            if (this.Color == LightColor.Green)
            {
                this.Color = LightColor.Yellow;
            }
            else if (this.Color == LightColor.Yellow)
            {
                this.Color = LightColor.Red;
            }
            else if (this.Color == LightColor.Red)
            {
                this.Color = LightColor.Green;
            }
        }
    }

    public enum LightColor
    {
        Green = 0,
        Yellow = 1,
        Red = 2
        //后期可以增加灯扩展
    }
}
