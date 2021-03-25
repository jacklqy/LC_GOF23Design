using GOF23._05建造者模式.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._05建造者模式
{
    /// <summary>
    /// 设计师 不造具体的车，只负责安排造车
    /// </summary>
    public class Director
    {
        private AbstractBuilder _AbstractBuilder = null;
        public Director(AbstractBuilder abstractBuilder)
        {
            this._AbstractBuilder = abstractBuilder;
        }
        public Car GetCar()
        {
            //对象的创建需要遵循一定的顺序，创建流程固定。
            this._AbstractBuilder.Engine();
            this._AbstractBuilder.Wheels();
            this._AbstractBuilder.Light();
            return this._AbstractBuilder.Car();
        }
    }
}
