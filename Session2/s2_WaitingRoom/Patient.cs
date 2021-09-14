using System;

namespace s2_WaitingRoom
{
    public class Patient
    {
        private int numberInQueue;
        private WaitingRoom wr;

        public Patient(WaitingRoom waitRoom)
        {
            wr = waitRoom;
            wr.NumberChange += ReactToNumber;
            numberInQueue = wr.DrawNumber();
        }

        public void ReactToNumber(int ticketNumber)
        {
            Console.WriteLine($"Patient {numberInQueue} looks up");
            if (ticketNumber == numberInQueue)
            {
                Console.WriteLine($"Patient {numberInQueue} goes to doctors office");
            }
            else
            {
                Console.WriteLine($"Patient {numberInQueue} sighs in despair");

            }
        }
    }
}