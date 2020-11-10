using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BusFilters
    {
        public List<Bus> marshNum(List<Bus> allBuses)
        {
            List<Bus> allFilteredBuses = new List<Bus>();
            Console.Write("Для фильтрации ведите номер маршрута: ");
            int marshnum = int.Parse(Console.ReadLine());
            foreach (Bus bus in allBuses)
            {
                if (bus.marshNum == marshnum)
                {
                    allFilteredBuses.Add(bus);
                }
            }
            return allFilteredBuses;
        }
        public List<Bus> year(List<Bus> allBuses)
        {
            List<Bus> allFilteredBuses = new List<Bus>();
            Console.Write("Для фильтрации введите количество лет эксплуатции: ");
            int year = int.Parse(Console.ReadLine());
            int todayYear = DateTime.Now.Year;
            Console.Write("Как отфильтровать?\n1.Больше n лет.\n2.Равно n лет.\n3.Меньше n лет.\n");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    foreach (Bus bus in allBuses)
                    {
                        if (todayYear - bus.year > year)
                        {
                            allFilteredBuses.Add(bus);
                        }
                    }
                    break;
                case "2":
                    foreach (Bus bus in allBuses)
                    {
                        if (todayYear - bus.year == year)
                        {
                            allFilteredBuses.Add(bus);
                        }
                    }
                    break;
                case "3":
                    foreach (Bus bus in allBuses)
                    {
                        if (todayYear - bus.year < year)
                        {
                            allFilteredBuses.Add(bus);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Было введено недопустимое значение.");
                    break;
            }

            return allFilteredBuses;
        }
        public List<Bus> probeg(List<Bus> allBuses)
        {
            List<Bus> allFilteredBuses = new List<Bus>();
            Console.Write("Для фильтрации ведите пробег автобуса: ");
            int probeg = int.Parse(Console.ReadLine());
            Console.Write("Как отфильтровать?\n1.Больше n километров.\n2.Равно n километров.\n3.Меньше n километров.\n");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    foreach (Bus bus in allBuses)
                    {
                        if (bus.probeg > probeg)
                        {
                            allFilteredBuses.Add(bus);
                        }
                    }
                    break;
                case "2":
                    foreach (Bus bus in allBuses)
                    {
                        if (bus.probeg == probeg)
                        {
                            allFilteredBuses.Add(bus);
                        }
                    }
                    break;
                case "3":
                    foreach (Bus bus in allBuses)
                    {
                        if (bus.probeg < probeg)
                        {
                            allFilteredBuses.Add(bus);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Было введено недопустимое значение.");
                    break;
            }

            return allFilteredBuses;
        }
        public List<Bus> marka(List<Bus> allBuses)
        {
            List<Bus> allFilteredBuses = new List<Bus>();
            Console.Write("Для фильтрации ведите марку автобуса: ");
            string marka = Console.ReadLine();
            foreach (Bus bus in allBuses)
            {
                if (bus.marka == marka)
                {
                    allFilteredBuses.Add(bus);
                }
            }
            return allFilteredBuses;
        }
    }
}
