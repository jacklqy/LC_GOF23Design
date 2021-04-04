using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._22状态模式.Light
{
    public class Context
    {
        public LightBase CurrentLight { get; set; }
        public void Show()
        {
            this.CurrentLight.Show();
        }

        public void Turn()
        {
            this.CurrentLight.TurnContext(this);//this表示当前类型的实例
        }
    }
}
