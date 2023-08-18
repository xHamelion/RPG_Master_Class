using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPG___Master_Class
{
    public class UIConsole
    {
        public UIConsole()
        {
            Console.Title = "RPG - Мастер класс";
            Console.WriteLine(
              "╔╦╦╦═╦╗╔═╦═╦══╦═╗" +
            "\n║║║║╩╣╚╣═╣║║║║║╩╣" +
            "\n╚══╩═╩═╩═╩═╩╩╩╩═╝\n\n\n");
            Thread.Sleep(5000);
            Console.Write("Ваша жизнь ничем не примичательна. Работа программистом за 20к рублей и дом в районах чертаново...\n" +
                "В задницу так?? Если бы жизнь была интереснее");
                Thread.Sleep(4000);
            for(int i = 0; i<6; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("Желания это вредно...");
            Thread.Sleep(2000);
            Console.WriteLine("Добро пожаловать, это - \"Бесконечный ад\" - сражайся или умри. Выхода нет!");
            Thread.Sleep(4000);
            Console.Clear();
            new PlayerControlGame().GeneratePerson();
            ConsoleUI();

        }

        public void ConsoleUI()
        {
            Console.WriteLine("Бой!");
            Console.Write("Враги/*");
            foreach (Enemi enemi in Holder.Enemis)
            {
                Console.Write($"    ");
                Console.Write("|");
                Console.Write($"{enemi.Name} - HP({enemi.HP})");
                Console.Write("|");
                Console.Write($"    ");

            }
            Console.Write("*/Враги");
            Console.WriteLine();
            Console.WriteLine(
"\n░░░░░░░░░░░░░░▄▄▄▄▄▄▄▄▄▄░░░░░░░░░░░░░░" +
"\n░░░░░░░░░▄▄██▀▀▀▀▀▀▀▀▀▀▀▀██▄▄░░░░░░░░░" +
"\n░░░░░░▄▄█▀▀░░░░░░▄██▄░░░░░░▀▀█▄░░░░░░░" +
"\n░░░░▄██▀░░░░░░░░▀████▀░░░░░░░░▀█▄░░░░░" +
"\n░░░▄█▀░▄▀░░░░░▄▄░████░▄▄░░░░░▀▄░▀█▄░░░" +
"\n░░██░▄██░░░░░▀▀████████▀▀░░░░░██░▀█▄░░" +
"\n░██░░██░░░░░░░░▀██████▀░░░░░░░░██░▀██░" +
"\n▄█░░░██░░░░░░░░░▀████▀░░░░░░░░░██░░▀█▄" +
"\n██░░░██▄░░░░░░░░░████░░░░░░░░░▄██░░░██" +
"\n██░░░▀██░░░░░░░░░████░░░░░░░░▄██▀░░░██" +
"\n██░█▄▄███▄░░░░░░██████░░░░░░▄███▄▄█░██" +
"\n█░▀████████▄▄██████████▄▄███████▀░░░█░" +
"\n▀█░░░░▀▀▀█████████░░█████████▀▀░▄░░▄█▀" +
"\n░██░░▀██▄▄▄░▀▀███████████▀░▄▄██▀░░▄█▀░" +
"\n░░██░░░░▀▀▀█░░██▀█▀▀█▀██░▄█▀▀░░░░▄█▀░░" +
"\n░░░▀█▄░░░░░▀█░▀█░█░░█░█▀░█▀░░░░░▄█▀░░░" +
"\n░░░░░██▄░░░░██░█░█░░█░█░██░░░░▄█▀░░░░░" +
"\n░░░░░░▀▀█▄▄░░▀░▀░▀░░▀░▀░▀░░▄██▀░░░░░░░" +
"\n░░░░░░░░░▀▀██▄▄▄▄▄▄▄▄▄▄▄███▀▀░░░░░░░░░" +
"\n░░░░░░░░░░░░░░▀▀▀▀▀▀▀▀▀▀░░░░░░░░░░░░░░\n");

            Holder.Hero.Info();


        }
    }
}
