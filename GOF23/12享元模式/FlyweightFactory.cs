using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._12享元模式
{
    /// <summary>
    /// 1 统一
    /// </summary>
    public class FlyweightFactory
    {
        //添加重用逻辑，静态字典缓存(非线程安全)
        private static Dictionary<WordType, BaseWord> _FlyweightFactoryDictionary = new Dictionary<WordType, BaseWord>();
        //锁
        private readonly static object FlyweightFactoryLock = new object();
        public static BaseWord CreateWord(WordType wordType)
        {
            //双if加锁
            if (!_FlyweightFactoryDictionary.ContainsKey(wordType))//外面在套一层判断，是为了优化性能，避免对象已经被初始化后，再次请求还需要等待锁。
            {
                lock (FlyweightFactoryLock)//Monitor.Enter，保证方法体只有一个线程可以进入
                {
                    if (!_FlyweightFactoryDictionary.ContainsKey(wordType))
                    {
                        BaseWord baseWord = null;
                        switch (wordType)
                        {
                            case WordType.E:
                                baseWord = new E();
                                break;
                            case WordType.L:
                                baseWord = new L();
                                break;
                            case WordType.V:
                                baseWord = new V();
                                break;
                            case WordType.N:
                                baseWord = new N();
                                break;
                            default:
                                throw new Exception("wrong wordtype!");
                        }
                        _FlyweightFactoryDictionary.Add(wordType, baseWord);
                    }
                }
            }
               
            return _FlyweightFactoryDictionary[wordType];
        }
    }

    public enum WordType
    {
        E,
        L,
        V,
        N
    }
}
