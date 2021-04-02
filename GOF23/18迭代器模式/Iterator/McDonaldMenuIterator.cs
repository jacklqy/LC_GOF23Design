using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._18迭代器模式.Menu
{
    /// <summary>
    /// 新的集合 实现了IIterator接口
    /// </summary>
    public class McDonaldMenuIterator : IIterator<Food>
    {

        private List<Food> _FoodList = null;
        public McDonaldMenuIterator(McDonaldMenu menu)
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
            return this._FoodList.Count > ++this._Index;//前++，表示先加1后在比较
        }

        public void Reset()
        {
            this._Index = -1;
        }
    }
}
