using GOF23._22状态模式.Light;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._22状态模式
{
    public class Context
    {
        //属性注入
        public LightBase CurrentLight { get; set; }//类的组合：字段注入、属性注入、方法注入、构造函数注入
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
