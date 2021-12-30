using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream streamobj = new FileStream("E:\\Test\\myfile.txt", FileMode.Open);
            StreamReader str = new StreamReader(streamobj);

            string[] Id = new string[12] ;
            string[] Source = new string[12];
            string[] Destination = new string[12];
            string[] Date = new string[12];
            string[] Status = new string[12];
            string[] Network = new string[12];
            
            Console.Write("enter details");
            Console.WriteLine("Id\t\tSource\t\tDestination\t\tDate\t\t Status\t\tNetwork");
            while (str.Peek() > 0)
            {
                string line = str.ReadLine();
                string[] values = line.Split(':');
                if (line != "")
                {
                    if (values.Length > 1)
                    {
                        if (line.StartsWith("Date"))
                        {
                            string date = values[1].Split(' ')[0];
                            Console.Write(values[1]);
                            Console.Write(date + "\t\t");
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                }    
            }

            str.Close();
            Console.ReadLine();


        }
    }
}
