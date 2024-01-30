using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Konsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zeilen = 40;
            int spalten = 80;

            int stern_x = 0;
            int stern_y = 1;

            Console.CursorVisible = false;

            string output = "";


            //infinite loop
            while(true)
            //for (int f = 0; f < 100; f++) - 100x
            {
                //stabiler Rahmen drch überschreiben statt löschen 
                Console.SetCursorPosition(0, 0);

                output = "";

                //stern x Koorinate plus 1 rechnen
                stern_x = stern_x + 1;


                //wenn stern ganz rechts angekommen ist > dann zurück nach links :: stern_x = 0
                if( stern_x  >= spalten)
                {
                    stern_x = 0;
                    stern_y = stern_y + 1;
                }

                if (stern_y >= zeilen)
                {
                    stern_y = 1;
                }

                for (int y = 0; y <= zeilen; y++)
                {
                    for (int x = 0; x <= spalten; x++)
                    {
                        if (y == 0 || y == zeilen)
                        {
                            //Console.Write("#");
                            output = output + "#";
                        }
                        else if (x == 0 || x == spalten)
                        {
                            //Console.Write("#");
                            output = output + "#";
                        }
                        else if (x == stern_x && y == stern_y)
                        {
                            //Console.Write("*");
                            output = output + "*";
                        }
                        else
                        {
                           //Console.Write(" ");
                            output = output + " ";
                        }

                    }
                    //Console.Write("\n");
                    output = output + "\n";
                }

                Console.Write(output);
                Thread.Sleep(32); 
            }
            
            Console.ReadKey();
        }
    }
}
