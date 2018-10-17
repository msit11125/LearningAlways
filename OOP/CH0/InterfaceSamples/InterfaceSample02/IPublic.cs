using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample02
{
    public interface IPublic
    {
        String GetString();
    }

    //明確實作介面
    public class ImplementIPublic : IPublic
    {
        string IPublic.GetString()
        {
            return "明確實作 ";
        }
    }

    // 此介面宣告方法與 IPublic 同名
    public interface IProtected
    {
        String GetString();
    }

    //如果類別實作了兩個包含相同簽章之成員的介面，則在類別上實作該成員會導致兩個介面都將該成員當做實作 (Implementation) 使用
    public class ImplementIPublicProtected : IPublic, IProtected
    {

        public string GetString()
        {
            return ("Comman");
        }
    }


    // 實做 IPublic, 明確實作 IProtected
    public class ImplementIPublicProtectedX : IPublic, IProtected
    {

        public string GetString()
        {
            return ("public");
        }

        string IProtected.GetString()
        {
            return ("protected");
        }
    }

    // 類別自己實做 GetString(), IPublic, IProtected 明確實作
    public class ImplementIPublicProtectedY : IPublic, IProtected
    {
        public string GetString()
        {
            return ("common");
        }

        string IProtected.GetString()
        {
            return ("protected");
        }

        string IPublic.GetString()
        {
            return ("public");
        }
    }


 
}
