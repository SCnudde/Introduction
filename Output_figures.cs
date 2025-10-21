using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {

            foreach (var item in File.ReadAllLines("Geometry.txt"))
            {
                Console.WriteLine(item);
            }           

        }
    }
}
