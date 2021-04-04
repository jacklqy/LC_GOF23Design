using GOF23._21观察者模式.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._21观察者模式.Subject
{
    /// <summary>
    /// 事情起源
    /// 大半夜猫叫了一声
    /// 
    /// baby cry
    /// dog wang
    /// father roar
    /// mother whisper
    /// ...
    /// </summary>
    class Cat
    {

        #region 方式一
        //违背设计模式六大原则：单一职责原则和迪米特法则
        public void Miao()
        {
            Console.WriteLine("{0} Miao 一声", this.GetType().Name);
            //一系列后续动作
            new Mouse().Run();//老鼠跑
            new Dog().Wang();//狗狗叫
            new Baby().Cry();//宝宝哭
            new Father().Roar();//爸爸怒
            new Mother().Whisper();//妈妈安抚
        }
        #endregion



        #region 方式二
        private List<IObserver> _Observers = new List<IObserver>();
        /// <summary>
        /// 添加观察者
        /// </summary>
        /// <param name="observer"></param>
        public void AddObserver(IObserver observer)
        {
            if (!this._Observers.Contains(observer))
                this._Observers.Add(observer);
        }
        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="observer"></param>
        public void RemoveObserver(IObserver observer)
        {
            if (this._Observers.Contains(observer))
                this._Observers.Remove(observer);
        }
        /// <summary>
        /// 事情起源或主题发布
        /// </summary>
        public void MiaoObserver()
        {
            Console.WriteLine("{0} MiaoObserver 一声", this.GetType().Name);
            foreach (var observer in this._Observers)
            {
                observer.Action();
            }
        }
        #endregion



        #region 方式三：委托事件
        public event Action CatMiaoEvent;
        public void MiaoEvent()
        {
            Console.WriteLine("{0} MiaoObserver 一声", this.GetType().Name);
            if (this.CatMiaoEvent != null)
                CatMiaoEvent.Invoke();
        } 
        #endregion

    }
}
