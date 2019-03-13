using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_File_io
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineIn;
            string[] fields = new string[6];
            
            string tableformat = "{0,-10}{1,-10}{2,-10}";
            int  Cost = 0;
           int Total1 = 0, Total2 = 0, Total3 = 0;
            int quantity = 0;






            FileStream fs4 = new FileStream("Sales.txt", FileMode.Open, FileAccess.Read);
            StreamReader inputStream = new StreamReader(fs4);

            Console.WriteLine(tableformat, "Customer", "Items", "Qauntity");
            lineIn = inputStream.ReadLine();
            while(lineIn != null)
            {
                fields = lineIn.Split(',');
                Console.WriteLine(tableformat, fields[0], fields[1], fields[2]);
                lineIn = inputStream.ReadLine();
            }
            inputStream.Close();
            Console.ReadLine();

          

            if(fields[1] != "Shirt")
            {
                Cost = 25;
                Total1 = Cost;
               
            }
            if (fields[1] != "Jumpers")
            {
                Cost = 30;
                Total2 = Cost;

            }
            if (fields[1] == "Trousers")
            {
                Cost = 35;
                Total3 = Cost;
            }
            

            quantity = int.Parse(fields[2]);
           Total1 = Total1 * quantity;
           

            Console.WriteLine("Shirt cost {0}", Total1);
            Console.WriteLine("Jumpers cost {0}", Total2);
            Console.WriteLine("Trousers cost {0}", Total3);

        }
    }
}
