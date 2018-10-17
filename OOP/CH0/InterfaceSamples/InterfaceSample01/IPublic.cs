using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample01
{
    public interface IPublic
    {
        string GetString();
    }

    // 實作介面    
    public class ImplementIPublic : IPublic
    {
        public string GetString()
        {
            return "ImplementIPublic";
        }
    }

    // 以抽象方式實作介面
    public abstract class AbstracClass : IPublic
    {
        public abstract string GetString();
    }

    // IExtend 拓展 IPublic, 但沒有同名成員
    public interface IExtend : IPublic
    {
        String GetExtendString();
    }

    // 實做 IExtend 會連同 IPublic 一起要求實作
    public class ImplementIExtend : IExtend
    {

        public string GetExtendString()
        {
            throw new NotImplementedException();
        }

        public string GetString()
        {
            throw new NotImplementedException();
        }
    }

    // 即使你宣告實作 IExtend 和 IPublic , IPublic 中的 GetString() 仍然只需要實做一次
    public class ImplementIExtendIPublic : IExtend, IPublic
    {
        public string GetExtendString()
        {
            throw new NotImplementedException();
        }

        public string GetString()
        {
            throw new NotImplementedException();
        }
    }
}
