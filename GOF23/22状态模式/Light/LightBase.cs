using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._22状态模式.Light
{
    public abstract class LightBase
    {
        /// <summary>
        /// 0 绿灯 1 黄灯 2 红灯
        /// </summary>
        public LightColor Color { get; set; }
        /// <summary>
        /// 交通信号灯显示
        /// </summary>
        public abstract void Show();

        /// <summary>
        /// 交通信号灯转换（可以去掉）
        /// 红灯转绿灯
        /// </summary>
        public abstract void Turn();

        public abstract void TurnContext(Context context);
    }
}
