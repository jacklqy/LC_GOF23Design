using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._22状态模式.Light
{
    /// <summary>
    /// 绿灯 简单意味着强大、简单意味着稳定
    /// </summary>
    public class LightGreen : LightBase
    {
        /// <summary>
        /// 初始化指定灯的颜色
        /// </summary>
        public LightGreen()
        {
            base.Color = LightColor.Green;
        }
        /// <summary>
        /// 交通信号灯显示
        /// </summary>
        public override void Show()
        {
            Console.WriteLine("绿灯行");
        }

        /// <summary>
        /// 交通信号灯转换
        /// 绿灯转黄灯
        /// </summary>
        public override void Turn()
        {
            this.Color = LightColor.Yellow;
        }

        public override void TurnContext(Context context)
        {
            context.CurrentLight = new LightYellow();//这里可以根据具体业务场景，考虑用享元模式，池化资源管理来获取，减少了new次数。
        }
    }
}
