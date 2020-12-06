using System;
using System.Collections.Generic;

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

            // Заново загрузили из файла
            File.FileToList(list, "../../../input.json");

            // Выводим в консоль чтобы оценить результат
            Console.WriteLine("Read:");
            Show.ShowList(list);

            try
            {
                Automobile auto4 = auto1 + auto2;
                list.Add(auto4);
                Console.WriteLine(auto4.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Невозможно выполнить операцию сложения");
            }

            try
            {
                Automobile auto5 = auto1 + auto3;
                list.Add(auto5);
                Console.WriteLine(auto5.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Невозможно выполнить операцию сложения");
            }


            try
            {
                Phone phone4 = phone1 - 500;
                list.Add(phone4);
                Console.WriteLine(phone4.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Невозможно выполнить операцию вычитания");
            }

            try
            {
                Phone phone5 = phone3 - 15;
                list.Add(phone5);
                Console.WriteLine(phone5.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Невозможно выполнить операцию вычитания");
            }

            try
            {
                int n = (int)watch1;
                Console.WriteLine(watch1.Name + " стоит " + n + " копеек");
            }
            catch (Exception)
            {
                Console.WriteLine("Невозможно выполнить операцию приведения");
            }

            try
            {
                double n = (double)watch1;
                Console.WriteLine(watch1.Name + " стоит " + n + " копеек");
            }
            catch (Exception)
            {
                Console.WriteLine("Невозможно выполнить операцию приведения");
            }


            Console.ReadKey();
        }
    }
}
