using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HomeConstructionHW
{
    enum Parting { Basement, Walls, Window, Door, Roof };

    public interface IPart
    {
        string GetName { get; }
    }
    public interface IWorker
    {
        House Construction(House house, Logger log);
    }

    class Program
    {
        public static object Options { get; private set; }

        static void Main(string[] args)
        {
            Logger log = new Logger();
            //
            int CountBasement = 1;
            int CountWalls = 4;
            int CountWindow = 4;
            int CountDoor = 1;
            int CountRoof = 1;
            //количество постоенных объектов согласно заданию
            int CountPart = CountBasement + CountWalls + CountWindow + CountDoor + CountRoof;
            House house = new House();
            Team team = new Team(CountPart);
            team.Work(house, log);
            house.Print();
            Console.ReadKey();
        }
    }
}
