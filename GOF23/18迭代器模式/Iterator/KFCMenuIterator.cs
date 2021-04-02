using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._18迭代器模式.Menu
{
    /// <summary>
    /// 新的集合 实现了IIterator接口
    /// </summary>
    public class KFCMenuIterator : IIterator<Food>
    {

        private Food[] _FoodList = null;
        public KFCMenuIterator(KFCMenu menu)
        {
            this._FoodList = menu.GetFoods();
        }
        private int _Index = -1;
        public Food Current
        {
            get
            {
                return this._FoodList[_Index];
            }
        }

        public bool MoveNext()
        {
            return this._FoodList.Length > ++this._Index;//前++，表示先加1后在比较
        }

        public void Reset()
        {
            this._Index = -1;
        }
    }
}
