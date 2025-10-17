using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GP_VirusLand_Kevin_GitHubRuinedMyJoke
{
    internal class Program
    {

        //all odd veriables are X, all even ones are Y
        static List<int> virusLocations = new List<int>();
        static int lastX;
        static int lastY;
        static int newX;
        static int newY;
        static int virusTotal = 3;
        static Random rando = new Random();
        //static char
        static void Main(string[] args)
        {
            virusLocations.Add(5);
            virusLocations.Add(5);
            virusLocations.Add(15);
            virusLocations.Add(5);
            virusLocations.Add(10);
            virusLocations.Add(15);
            
            Console.CursorVisible = false;
            while (true)
            {

                








                Console.BackgroundColor = ConsoleColor.Black;
                for (int x = 0; x > (virusTotal * 2); x += 2)
                {
                    
                    lastX = x;
                    for (int y = 1; y > (virusTotal * 2); y += 2)
                    {
                        Console.SetCursorPosition(x,y)
                        Console.Write("X");
                        
                        int move = rando.Next(1,4);
                        int doup = rando.Next(1, 10);
                        
                        lastY = y;
                        if (move == 1)
                        {
                            newX = virusLocations[x] + 1;
                            if (newX < 15)
                            {
                                if (true)
                                {
                                    virusLocations[x] = newX;
                                }
                            }
                        }
                        else if (move == 2)
                        {
                            newX = virusLocations[x] - 1;
                            if (newX > 5)
                            {
                                if (true)
                                {
                                    virusLocations[x] = newX;
                                }
                            }
                        }
                        else if (move == 3)
                        {
                            newY = virusLocations[y] + 1;
                            if (newY < 15)
                            {
                                if (true)
                                {
                                    virusLocations[y] = newY;
                                }
                            }
                        }
                        else if (move == 4)
                        {
                            newY = virusLocations[y] - 1;
                            if (newY > 5)
                            {
                                if (true)
                                {
                                    virusLocations[y] = newY;
                                }
                            }
                        }
                        if (lastX != virusLocations[x])
                        {
                            if (doup == 10)
                            {
                                virusLocations.Add(lastX);
                                virusLocations.Add(lastY);
                                virusTotal++;
                            }
                        }
                        if (lastY != virusLocations[x])
                        {
                            if (doup == 10)
                            {
                                virusLocations.Add(lastX);
                                virusLocations.Add(lastY);
                                virusTotal++;
                            }
                        }
                        Console.SetCursorPosition(virusLocations[x], virusLocations[y]);
                        Console.Write("X");
                    }
                }
                Thread.Sleep(100);
            }







        }

    }
}