using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamAndStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stream = sequencia de dados
            string path = @"c:\temp\file1.txt";
            string path2 = @"c:\temp\file3.txt";

            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                StreamReader srTest = new StreamReader(path2);
                fs = new FileStream(path, FileMode.Open);  
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                while(line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();

                }
                Console.WriteLine("Fim do texto");
                Console.ReadKey();
            }catch(IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                fs.Close();
                sr.Close();
            }

        }
    }
}
