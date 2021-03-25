using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._05建造者模式.Model
{
    /// <summary>
    /// 车
    /// </summary>
    public class Car
    {
        public string Name { get; set; }
        public Car(Engine engine,Wheels wheels,Light light)
        {

        }
    }
}
