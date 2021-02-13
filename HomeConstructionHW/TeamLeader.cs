using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HomeConstructionHW
{
    class TeamLeader : IWorker
    {
        public House Construction(House house, Logger log)
        {
            Console.WriteLine("На данный момент в доме построено :");
            List<IPart> temp_house = house.GetHouse();
            for (int i = 0; i < house.CounterPart(); i++)
                Console.WriteLine(temp_house.ElementAt(i).GetName);
            return house;
        }
    }
}
