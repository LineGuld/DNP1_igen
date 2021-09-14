using System;

namespace s2_WaitingRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitingRoom waitingRoom = new WaitingRoom();

            Patient patient1 = new Patient(waitingRoom);
            Patient patient2 = new Patient(waitingRoom);
            Patient patient3 = new Patient(waitingRoom);
            Patient patient4 = new Patient(waitingRoom);

            /*waitingRoom.NumberChange += patient1.ReactToNumber;
            waitingRoom.NumberChange += patient2.ReactToNumber;
            waitingRoom.NumberChange += patient3.ReactToNumber;
            waitingRoom.NumberChange += patient4.ReactToNumber;*/
            
            waitingRoom.RunWaitingRoom();
        }
    }
}