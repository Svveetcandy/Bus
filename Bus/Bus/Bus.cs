using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bus
    {
        public string Name { get; }
        public int busNum { get; }
        public int marshNum { get; }
        public string marka { get; }
        public int year { get; }
        public int probeg { get; }
        public Bus()
        {
            Console.Write("Введите фамилию и инициалы: ");
            Name = Console.ReadLine();
            Console.Write("Введите номер автобуса: ");
            busNum = int.Parse(Console.ReadLine());
            Console.Write("Введите номер маршрута:");
            marshNum = int.Parse(Console.ReadLine());
            Console.Write("Введите марку автобуса: ");
            marka = Console.ReadLine();
            Console.Write("Введите год начала эксплуатации автобуса: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Введите пробег автобуса: ");
            probeg = int.Parse(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine("ФИО: {0}", Name);
            Console.WriteLine("Номер автобуса: {0}", busNum);
            Console.WriteLine("Номер маршрута: {0}", marshNum);
            Console.WriteLine("МаркА автобуса: {0}", marka);
            Console.WriteLine("Год начала эксплуатации автобуса: {0}", year);
            Console.WriteLine("Пробег автобуса: {0}", probeg);
        }
    }
}