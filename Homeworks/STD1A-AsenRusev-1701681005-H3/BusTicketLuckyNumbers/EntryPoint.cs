using System;

namespace BusTicketLuckyNumbers
{
    class EntryPoint
    {
        static void Main()
        {
            int luckyTickets = 0;
            int unluckyTickets = 0;
            int totalTickets = 0;
            int leftSide = 0;
            int rightSide = 0;

            for (int i = 0; i <= 999999; i++)
            {
                for (int j = 1; j <= 100; j*=10)
                {
                    rightSide += (i / j) % 10;
                }

                for (int j = 1000; j <= 100000; j*=10)
                {
                    leftSide += (i / j) % 10;
                }

                if(leftSide == rightSide)
                {
                    luckyTickets++;
                    Console.WriteLine(i);
                }
                else
                {
                    unluckyTickets++;
                }

                totalTickets++;
                rightSide = 0;
                leftSide = 0;
            }

            Console.WriteLine($"Total lucky ticket numbers are {luckyTickets}");
            Console.WriteLine($"Total not lucky ticket numbers are {unluckyTickets}");
            Console.WriteLine($"Total tickets existing are {totalTickets}");
        }
    }
}
