using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b=0;
            byte[] data = File.ReadAllBytes("D:filename.dat"); //表示したいファイル名
            foreach (int n in data) {
                if (b == 7)
                {
                    Console.Write('\n');
                    b = 0;
                }
                else
                {
                    b++;
                }
                Console.Write(n.ToString("X2"));
                Console.Write(" " );
            }
            Console.ReadLine();
        }
    }
}
