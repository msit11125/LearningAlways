using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample02
{
    public sealed class SingletonClass
    {
        private int i = 0;
        private SingletonClass()
        {

        }

        public void Show()
        {
            Console.WriteLine("Hello " + i.ToString());
            i += 1;
        }

        private static SingletonClass _singletonObject;
        private static object _syncRoot = new object();
        public static SingletonClass SingletonObject
        {
            get
            {
                if (_singletonObject == null)
                {
                    lock (_syncRoot) // 不能lock自己 會鎖死 ， 
                    {   // 執行緒進來 lock變1                                   
                        // 永保安康, 再確認一次 null
                        if (_singletonObject == null)
                        {
                            GetSingleton();
                        }

                    }   // 執行緒出去 lock變0
                }
                return _singletonObject;
            }
        }

        private static void GetSingleton()
        {
            _singletonObject = new SingletonClass();
        }
    }
}
