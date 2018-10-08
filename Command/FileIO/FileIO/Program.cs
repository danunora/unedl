using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        const int SIZE = 100;
        static void Main(string[] args)
        {
            FileStream fh = new FileStream("archivo.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 0; i <= SIZE; i++)
            {
                fh.WriteByte((byte)i);
            }
            fh.Position = 0;
            for (int i = 0; i <= SIZE; i++)
            {
                Console.Write(fh.ReadByte() + " ");
            }
            fh.Close();
            Console.ReadKey();
        }
    }
}
