using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace task_2
{
    public class File
    {
        public static void SaveToJson(Product obj)
        {
            string json = JsonSerializer.Serialize<Product>(obj);
            Console.WriteLine(json);
        }

        public static void ListToFile(List<Product> list, string path)
        {
            //FileStream file = new FileStream(path, FileMode.Create);

            StreamWriter file = new StreamWriter(path, false, System.Text.Encoding.Default);

            foreach (var i in list)
            {
                string json = JsonSerializer.Serialize<Product>(i);
                json += "\n";
                //Console.WriteLine("json string: " + json);

                file.Write(json);

                /*
                byte[] bytes1 = Encoding.ASCII.GetBytes(json);
                Console.Write("ASCII byte string: ");
                for (int j = 0; j < bytes1.Length; j++) Console.Write(bytes1[j]);
                
                Console.WriteLine("\n");

                byte[] bytes2 = System.Text.Encoding.ASCII.GetBytes(json);
                Console.Write("ASCII byte string: ");
                for (int j = 0; j < bytes2.Length; j++) Console.Write(bytes2[j]);

                Console.WriteLine("\n");
                Console.WriteLine("\n");
              

                //Дичь какая-то
                //file.Write(bytes2, 8, bytes1.Length / 8);

                file.Write(bytes2, 8, 20*8);
                */

                //JsonSerializer.SerializeAsync<Product>(file, i);

            }

            file.Close();
        }

        public static void FileToList(List<Product> list, string path)
        {
            //FileStream file = new FileStream(path, FileMode.Open);
            StreamReader file = new StreamReader(path);

            string line = "\n";
            //string str = file.ReadLine();

            while ((line = file.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                Product restoredProduct = JsonSerializer.Deserialize<Product>(line);
                //Console.Write("result : " + restoredProduct.ToString());
                list.Add(restoredProduct);
                //Console.WriteLine("\n");
            }

            //Product restoredPerson =  JsonSerializer.DeserializeAsync<Product>(file);
            

            file.Close();
        }
    }
}
