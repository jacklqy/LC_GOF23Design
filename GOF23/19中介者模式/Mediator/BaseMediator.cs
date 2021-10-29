using GOF23._19中介者模式.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._19中介者模式.Mediator
{
    /// <summary>
    /// 中介者（类似QQ群）
    /// </summary>
    public class BaseMediator
    {
        public string Name { get; set; }
        private List<BaseCharacter> _CharacterList = null;
        public BaseMediator()
        {
            _CharacterList = new List<BaseCharacter>();
        }

        /// <summary>
        /// 添加成员
        /// </summary>
        /// <param name="character"></param>
        public void AddCharacter(BaseCharacter character)
        {
            this._CharacterList.Add(character);
        }

        /// <summary>
        /// 发消息
        /// </summary>
        /// <param name="message"></param>
        /// <param name="characterTo"></param>
        public void SendMessage(string message, BaseCharacter characterFrom)
        {
            Console.WriteLine("{0}Send：{1}", characterFrom.Name, message);
            foreach (var item in this._CharacterList)
            {
                item.GetMessage(message, characterFrom);
            }
        }
    }
}
