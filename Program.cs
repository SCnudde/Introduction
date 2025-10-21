using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_desk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cellsize;            
            Console.WriteLine("Введите размер клетки: "); int.TryParse(Console.ReadLine(), out cellsize); 

            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < cellsize; j++, Console.WriteLine())
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            if (k % 2 == 0)
                            {
                                for (int h = 0; h < cellsize; h++)
                                {
                                    Console.Write("*");
                                }
                            }
                            else
                            {
                                for (int h = 0; h < cellsize; h++)
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                        
                    }
                }
                else
                {
                    for (int j = 0; j < cellsize; j++, Console.WriteLine())
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            if (k % 2 == 0)
                            {
                                for (int g = 0; g < cellsize; g++)
                                {
                                    Console.Write(" ");
                                }
                            }
                            else
                            {
                                for (int g = 0; g < cellsize; g++)
                                {
                                    Console.Write("*");
                                }
                            }
                        }
                        
                    }
                }
            }
        }    
    }
}
