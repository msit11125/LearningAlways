using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample01
{
    public sealed class SingletonClass
    {
        private int i = 0;

        // 設private就不能new 
        // 外部要存取就透過SingletonObject屬性存取
        private SingletonClass() 
        {

        }

        public void Show()
        {
            Console.WriteLine("Hello " + i.ToString());
            i += 1;
        }

        private static SingletonClass _singletonObject;
        public static SingletonClass SingletonObject
        {
            get
            {
                if (_singletonObject == null)
                {
                    GetSingleton();
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
