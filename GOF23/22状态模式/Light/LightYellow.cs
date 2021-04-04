using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._22状态模式.Light
{
    /// <summary>
    /// 黄灯 简单意味着强大、简单意味着稳定
    /// </summary>
    public class LightYellow : LightBase
    {
        /// <summary>
        /// 初始化指定灯的颜色
        /// </summary>
        public LightYellow()
        {
            base.Color = LightColor.Yellow;
        }
        /// <summary>
        /// 交通信号灯显示
        /// </summary>
        public override void Show()
        {
            Console.WriteLine("黄灯请小心");
        }

        /// <summary>
        /// 交通信号灯转换
        /// 黄灯转红灯
        /// </summary>
        public override void Turn()
        {
            this.Color = LightColor.Red;
        }

        public override void TurnContext(Context context)
        {
            context.CurrentLight = new LightRed();//这里可以根据具体业务场景，考虑用享元模式，池化资源管理来获取，减少了new次数。
        }
    }
}
