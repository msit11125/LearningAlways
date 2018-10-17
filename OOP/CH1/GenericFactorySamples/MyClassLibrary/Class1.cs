using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
   public interface IDbProcess
    {
        string GetName();
    }

    public class SqlDbProcess : IDbProcess
    {
        public string GetName()
        {
            return "SQL DB";
        }
    }

    public class OleDbProcess : IDbProcess
    {
        public string GetName()
        {
            return "Access DB";
        }
    }
}
