using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //只能使用到Template方法
            Communication communication = new SocketCommunication();
            communication.SendCommand(new byte[1]);
        }
    }
}
