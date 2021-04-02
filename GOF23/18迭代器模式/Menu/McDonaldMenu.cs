using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._18迭代器模式.Menu
{
    /// <summary>
    /// 麦当劳菜单
    /// </summary>
    public class McDonaldMenu
    {
        private List<Food> _FoodList = new List<Food>();
        public McDonaldMenu()
        {
            this._FoodList.Add(new Food()
            {
                Id = 1,
                Name = "鸡肉卷",
                Price = 15
            });
            this._FoodList.Add(new Food()
            {
                Id = 2,
                Name = "红豆派",
                Price = 10
            });
            this._FoodList.Add(new Food()
            {
                Id = 3,
                Name = "薯条",
                Price = 9
            });
        }
        public List<Food> GetFoods()
        {
            return this._FoodList;
        }

        /// <summary>
        /// 迭代器
        /// </summary>
        /// <returns></returns>
        public IIterator<Food> GetIterator()
        {
            return new McDonaldMenuIterator(this);
        }
    }
}
