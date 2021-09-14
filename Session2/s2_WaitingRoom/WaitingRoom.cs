using System;
using System.Threading;

namespace s2_WaitingRoom
{
    public class WaitingRoom
    {
        public Action<int> NumberChange;
        private int currentNumber = 0;
        private int ticketCounter = 0;

        public void RunWaitingRoom()
        {
            while (currentNumber < ticketCounter)
            {
                Console.WriteLine($"Current number is {currentNumber}");
                NumberChange?.Invoke(currentNumber);
                currentNumber++;
                
                Console.WriteLine($"Patient number {currentNumber} can now enter");
                Thread.Sleep(2000);
            }
        }

        public int DrawNumber()
        {
            ticketCounter++;
            return ticketCounter;
        }
    }
}