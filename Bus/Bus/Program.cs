using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool escape = false;
            List<Bus> buses = new List<Bus>();
            List<Bus> filteredBuses = new List<Bus>();
            BusFilters filter = new BusFilters();
            while (!escape)
            {
                Console.Clear();
                Console.Write("1.Добавить автобус в список.\n2.Фильтр по маршруту.\n3.Фильтр по эксплуатации\n4.Фильтр по пробегу\n5. Фильтр по марке.\n6. Выход.\n");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        buses.Add(new Bus());
                        break;
                    case "2":
                        filteredBuses.Clear();
                        filteredBuses = filter.marshNum(buses);
                        foreach (Bus bus in filteredBuses)
                        {
                            bus.Print();
                        }
                        break;
                    case "3":
                        filteredBuses.Clear();
                        filteredBuses = filter.year(buses);
                        foreach (Bus bus in filteredBuses)
                        {
                            bus.Print();
                        }
                        break;
                    case "4":
                        filteredBuses.Clear();
                        filteredBuses = filter.probeg(buses);
                        foreach (Bus bus in filteredBuses)
                        {
                            bus.Print();
                        }
                        break;
                    case "5":
                        filteredBuses.Clear();
                        filteredBuses = filter.marka(buses);
                        foreach (Bus bus in filteredBuses)
                        {
                            bus.Print();
                        }
                        break;
                    case "6":
                        escape = true;
                        break;
                    default:
                        Console.WriteLine("Было введено недопустимое значение.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
