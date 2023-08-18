using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPG___Master_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerControlGame game = new PlayerControlGame();
            game.Start();
            //string[] all = File.ReadAllLines("red.txt");
            //foreach(string c in all)
            //    Console.WriteLine(c);
            //Console.ReadLine();
        }
    }
}
