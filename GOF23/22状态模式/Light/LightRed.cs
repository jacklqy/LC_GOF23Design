using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._22状态模式.Light
{
    /// <summary>
    /// 红灯 简单意味着强大、简单意味着稳定
    /// </summary>
    public class LightRed : LightBase
    {
        /// <summary>
        /// 初始化指定灯的颜色
        /// </summary>
        public LightRed()
        {
            base.Color = LightColor.Red;
        }
        /// <summary>
        /// 交通信号灯显示
        /// </summary>
        public override void Show()
        {
            Console.WriteLine("红灯停");
        }

        /// <summary>
        /// 交通信号灯转换
        /// 红灯转绿灯
        /// </summary>
        public override void Turn()
        {
            this.Color = LightColor.Green;
        }

        public override void TurnContext(Context context)
        {
            context.CurrentLight = new LightGreen();//这里可以根据具体业务场景，考虑用享元模式，池化资源管理来获取，减少了new次数。
        }
    }
}
