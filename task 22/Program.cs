using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Text.Json.NET;
using System.Text.Json.Serialization;

//using Library;

namespace task_2
{
    class Program   
    {
        static void Main()
        {
            Automobile auto1 = new Automobile("BMW",  150000, 0.50, 40);
            Automobile auto2 = new Automobile("Audi", 200000, 0.55, 45);
            Automobile auto3 = new Automobile("BMW",  175000, 0.60, 50);

            Phone phone1 = new Phone("Samsung",  87000, 0.30, 100500);
            Phone phone2 = new Phone("Apple",   100000, 0.35, 4500);
            Phone phone3 = new Phone("Nokia",     7500, 0.29, 10);

            WristWatch watch1 = new WristWatch("Rolex", 2550001, 0.75, 35);
            WristWatch watch2 = new WristWatch("Ziko",     2550, 0.20,  30000);
            WristWatch watch3 = new WristWatch("Rolex",  450000, 0.89, 28);

            List<Product> list = new List<Product>();

            list.Add(auto1);
            list.Add(auto2);
            list.Add(auto3);

            list.Add(phone1);
            list.Add(phone2);
            list.Add(phone3);

            list.Add(watch1);
            list.Add(watch2);
            list.Add(watch3);

            // Сохранили в файл
            File.ListToFile(list, "../../../input.json");

            // Очистили список
            list.Clear();

            // Наново загрузили из файла
            File.FileToList(list, "../../../input.json");

            // Выводим в консоль чтобы оченить результат
            Console.WriteLine("Read: ");
            Show.ShowList(list);
            



            Console.ReadKey();
        }
    }
}
