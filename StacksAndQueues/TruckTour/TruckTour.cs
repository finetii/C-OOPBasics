using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTour
{

    public class GasPump
    {
        public int distanceToNext;
        public int amountOfGas;
        public int indexOfPump;

        public GasPump(int distance, int amountOfGas, int indexOfPump)
        {
            this.distanceToNext = distance;
            this.amountOfGas = amountOfGas;
            this.indexOfPump = indexOfPump;
        }
    }
    class TruckTour
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<GasPump> pumps = new Queue<GasPump>();

            for (int i = 0; i < n; i++)
            {
                string[] pumpInfo = Console.ReadLine().Split();

                pumps.Enqueue(new GasPump(int.Parse(pumpInfo[1]), int.Parse(pumpInfo[0]),i));
            }

            bool completeJourney = false;
            while (pumps.Count > 0)
            {
                GasPump startPump = null;
                GasPump currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);
                startPump = currentPump;
                int gasInTank = currentPump.amountOfGas;
                while(gasInTank >= currentPump.distanceToNext)
                {
                    gasInTank -= currentPump.distanceToNext;
                    currentPump = pumps.Dequeue();
                    pumps.Enqueue(currentPump);
                    if (currentPump == startPump)
                    {
                        completeJourney = true;
                        break;
                        
                    }
                    gasInTank += currentPump.amountOfGas;
                }
                if(completeJourney)
                {
                    Console.WriteLine(currentPump.indexOfPump);
                    break;
                }
            }
        }
    }
}
