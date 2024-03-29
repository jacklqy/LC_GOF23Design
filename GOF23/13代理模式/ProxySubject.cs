﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._13代理模式
{
    public class ProxySubject : ISubject
    {
        //3、单例代理(双if+锁)
        private static ISubject _iSubject = null;//new RealSubject();
        /// <summary>
        /// 锁，微软官方推荐static readonly
        /// </summary>
        private static readonly object _Singletion_Lock = new object();
        private void Init()
        {
            //双if加锁
            if (_iSubject == null)//外面在套一层判断，是为了优化性能，避免对象已经被初始化后，再次请求还需要等待锁。
            {
                lock (_Singletion_Lock)//可以保证任何时候只有一个线程进入，其他线程等待。
                {
                    if (_iSubject == null)
                    {
                        _iSubject = new RealSubject();//5、延迟代理，把一开始就构造对象换成了 延迟到 调用Init才会初始化
                    }
                }
            }
            
        }
        public void DoSomethingLong()
        {
            try
            {
                Console.WriteLine("prepare DoSomethingLong write log 写日志代理...");
                if (_iSubject == null)
                {
                    this.Init();
                }
                _iSubject.DoSomethingLong();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
        }

        public List<string> GetSomethingLong()
        {
            try //2、异常代理
            {
                //6、权限代理
                //object user = CallContext.GetData("CurrentUser");
                //if (user == null)
                //{
                //    throw new Exception("你没有权限访问");
                //}

                //1、日志代理
                Console.WriteLine("prepare GetSomethingLong write log 写日志代理...");
                //4、缓存代理
                string key = $"{nameof(ProxySubject)}_{nameof(GetSomethingLong)}";
                if (!CustomCache.Exists(key))
                {
                    if (_iSubject == null)
                    {
                        this.Init();
                    }
                    CustomCache.Add(key, _iSubject.GetSomethingLong());
                }
                return CustomCache.Get<List<string>>(key);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
