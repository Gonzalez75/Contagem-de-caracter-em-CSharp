using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp2
{
    internal class Program
    {



        static void Main(string[] args)
        {
            FileStream infile, outfile;
            String buffer = "";
            char anterior, atual;
            int cont = 0;

            infile = new System.IO.FileStream("teste1.txt", FileMode.Open, FileAccess.Read);
            outfile = new System.IO.FileStream("respostateste.txt", FileMode.Create, FileAccess.Write);

            anterior = (char)infile.ReadByte();
            ++cont;
            for (int i = 0; i <= infile.Length; ++i)
            {
                atual = (char)infile.ReadByte();

                if (atual == anterior)
                {
                    cont++;

                }
                else
                {
                    Console.WriteLine("{0} - {1}", cont, anterior);
                    outfile.WriteByte((byte)cont);
                    outfile.WriteByte((byte)anterior);

                    cont = 1;
                    anterior = atual;

                   
                }


            }
            infile.Close();
            outfile.Close();
            Console.ReadKey();
        }
    }
}
