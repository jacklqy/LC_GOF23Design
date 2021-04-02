using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._18迭代器模式.Menu
{
    /// <summary>
    /// 德克士菜单
    /// </summary>
    public class DicosMenu
    {

        private Dictionary<int, Food> _FoodDic = new Dictionary<int, Food>();
        public DicosMenu()
        {
            this._FoodDic.Add(0, new Food()
            {
                Id = 1,
                Name = "脆皮炸鸡",
                Price = 15
            });
            this._FoodDic.Add(1, new Food()
            {
                Id = 2,
                Name = "咔哧咔哧",
                Price = 10
            });
            this._FoodDic.Add(2, new Food()
            {
                Id = 3,
                Name = "薯条",
                Price = 8
            });
        }
        public Dictionary<int, Food> GetFoods()
        {
            return this._FoodDic;
        }

        /// <summary>
        /// 迭代器
        /// </summary>
        /// <returns></returns>
        public IIterator<Food> GetIterator()
        {
            return new DicosMenuIterator(this);
        }
    }
}
