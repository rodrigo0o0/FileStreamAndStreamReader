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

            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);

                }
                Console.WriteLine("Fim do texto");
                Console.WriteLine();
                Console.ReadKey();
     
            }catch(IOException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            finally
            {
                if(sr != null) sr.Close();
            }

        }
    }
}
