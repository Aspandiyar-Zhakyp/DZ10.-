using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HomeConstructionHW
{
    class Team
    {
        private IWorker teamLeader;
        private Worker[] workers;
        public Team(int count)
        {
            teamLeader = new TeamLeader();
            workers = new Worker[count];
            for (int i = 0; i < count; i++)
                workers[i] = new Worker();
        }
        private int Choice(Logger log)
        {
            int choice = 0;
            while ((choice < 1) | (choice > 2))
            {
                Console.WriteLine("Ваши действия? \n 1) Построить следующий объект \n " +
                        "2) Вызвать бригадира и получить отчёт о строительстве");
                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    log.Write(ex);
                }
            }
            return choice;
        }
        public House Work(House house, Logger log)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                int choice = Choice(log);
                if (choice == 1)
                {
                    house = workers[i].Construction(house, log);
                }
                else if (choice == 2)
                {
                    teamLeader.Construction(house, log);
                    i--;
                }
            }
            Console.WriteLine("Дом построен!!!");
            return house;
        }
    }
}
