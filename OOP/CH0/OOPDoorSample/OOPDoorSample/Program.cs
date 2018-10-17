using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDoorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            OODoor carDoor = new CarDoor();

            // 保證不會呼叫到 RoomDoor 的 Open , Close
            carDoor.Open();
            carDoor.Close(); 

        }
    }
}
