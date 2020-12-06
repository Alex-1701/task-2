using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public class Show
    {
        public static void ShowList(List<Product> data)
        {
            foreach (var item in data)
                Console.WriteLine(item.ToString());
        }
    }
}
