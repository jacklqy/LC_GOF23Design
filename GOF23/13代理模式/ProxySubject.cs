using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._13代理模式
{
    public class ProxySubject : ISubject
    {
        //3、单例代理
        private static ISubject _iSubject = null;//new RealSubject();
        private void Init()
        {
            _iSubject = new RealSubject();//5、延迟代理，把一开始就构造对象换成了 延迟到 调用Init才会初始化
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
