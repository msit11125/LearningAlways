using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDoorSample
{
    public abstract class OODoor
    {

        public Int32 Width
        { get; set; }

        public Int32 Height
        { get; set; }

        public bool Opened
        { get; protected set; }

        public abstract void Open();

        public abstract void Close();
    }

    public class CarDoor : OODoor
    {
        public override void Open()
        {
            //開車門的程序
            Opened = true;
        }

        public override void Close()
        {
            //關車門的程序
            Opened = false;
        }
    }

    public class RoomDoor : OODoor
    {
        public override void Open()
        {
            //開房間門的程序
            Opened = true;
        }

        public override void Close()
        {
            //關房間門的程序
            Opened = false;
        }
    }
}
