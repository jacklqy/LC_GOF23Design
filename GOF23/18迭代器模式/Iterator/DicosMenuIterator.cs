using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._18迭代器模式.Menu
{
    /// <summary>
    /// 新的集合 实现了IIterator接口
    /// </summary>
    public class DicosMenuIterator : IIterator<Food>
    {

        private Dictionary<int, Food> _FoodDic = null;
        public DicosMenuIterator(DicosMenu menu)
        {
            this._FoodDic = menu.GetFoods();
        }
        private int _Index = -1;
        public Food Current
        {
            get
            {
                return this._FoodDic[_Index];
            }
        }

        public bool MoveNext()
        {
            return this._FoodDic.Count > ++this._Index;//前++，表示先加1后在比较
        }

        public void Reset()
        {
            this._Index = -1;
        }
    }
}
