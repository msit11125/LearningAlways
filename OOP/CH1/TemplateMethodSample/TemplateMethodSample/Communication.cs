using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodSample
{
    public abstract class Communication
    {
        //範本方法 通用實作 給Client使用
        public byte[] SendCommand(byte [] command)
        {
            Send(command);            
            return Receive();
        }

        protected abstract void Send(byte[] command);

        protected abstract byte[] Receive();
    }


    public class SocketCommunication : Communication
    {
        private Socket owner;

        public SocketCommunication ()
        {
            owner = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Tcp);
            owner.Connect("192.168.1.1", 1009);
        }
       

        protected override void Send(byte[] command)
        {          
            owner.Send(command);
        }

        protected override byte[] Receive()
        {
            byte[] buffer = new byte[1024];
            owner.Receive(buffer);
            return buffer;
        }
    }


    public class SerialCommunication : Communication
    {
        private SerialPort owner;
       
         public SerialCommunication ()
        {
            owner = new SerialPort("COM1");
        }
        protected override void Send(byte[] command)
        {
            owner.Write(command, 0, command .Length );
        }

        protected override byte[] Receive()
        {
            byte[] buffer = new byte[1024];
            owner.Read(buffer, 0, buffer.Length);
            return buffer;
        }

    }
}
