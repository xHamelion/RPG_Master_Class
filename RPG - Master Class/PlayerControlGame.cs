using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPG___Master_Class
{
    public class PlayerControlGame
    {
        Random rnd = new Random();
        UIConsole InfoPrint;
        
        public void GeneratePerson()
        {
            Hero person = null;
            Console.Write("Введите имя вашего персонажа: ");
            string name = Console.ReadLine();
            Console.WriteLine("=============================");
            int num;
            Console.WriteLine("Выбирите класс персонажа: " +
                "\n1 - Войн (Сложный)" +
                "\n2 - Друид (Средний)" +
                "\n3 - Паладин (Легкий)" +
                "\n(введите цифру)");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Не правильный ввод. Выбран класс - Войн");
                num = 1;
            }
            switch (num)
            {
                case 1:
                    person = new Warior(name,100);
                    break;
                case 2:
                    person = new Druid(name, 100);

                    break;
                case 3:
                    person = new Paladin(name, 100);
                    break;
                default:
                    person = new Warior(name, 100);

                    break;
            }
            Holder.Hero = person;
            Console.Clear();

        }

        public void Start()
        {

            InfoPrint = new UIConsole();
            Console.Clear();
            Batle();
        }

        public void NewGenerate()
        {
            Console.Clear();
            Holder.Hero.RepairStats();


            int num = rnd.Next(1, 4);
            int enemidamage = 0;
            int enemiHP = 0;

            for (int i = 0; i < num; i++)
            {
                try
                {
                    enemidamage = Holder.Hero.Damage -  rnd.Next(3, Convert.ToInt32(Holder.Hero.Damage / 3) );

                }
                catch { enemidamage = Holder.Hero.Damage; }
                enemiHP = Holder.Hero.HP - rnd.Next(15, Holder.Hero.HP_Max - 50);
                switch (rnd.Next(1, 4))
                {
                    case 1:
                        Holder.Enemis.Add(new EnemiSkilet(enemiHP, enemidamage, "Скелет"));
                        break;
                    case 2:
                        Holder.Enemis.Add(new EnemiSlime(enemiHP, enemidamage, "Слайм"));
                        break;
                    case 3:
                        Holder.Enemis.Add(new EnemiSpider(enemiHP, enemidamage, "Паук"));
                        break;
                    default:
                        break;
                }



            }
            


        }
        public void Batle()
        {
            NewGenerate();

            while (true)
            {
                Console.Clear();
                InfoPrint.ConsoleUI();

                Console.WriteLine($"Вас атакуют: {Holder.Enemis[0].Name} - урон: " +
                    $"{Holder.Enemis[0].Damage}");
                Holder.Enemis[0].EnemiAttac(Holder.Hero);
                Console.WriteLine("Настало мое время для атаки. Я выбираю:");
                Atack();
                if(Holder.Enemis.Count == 0)
                {
                    
                    NewGenerate();
                }
            }

        }
        
        void Atack()
        {
            switch (Holder.Hero.Class)
            {
                case "Войн":
                    Console.WriteLine("1 - атака мечом (MP - 0)");
                    Console.WriteLine("2 - атака кинжалами (MP - 10)");
                    Console.WriteLine("3 - востановление 20 HP (MP - 20)");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Holder.Hero.HeroAtack(Holder.Enemis[0]);

                            break;
                        case "2":
                            (Holder.Hero as Warior).WariorAttacKnight(Holder.Enemis[0]);

                            break;
                        case "3":
                            (Holder.Hero as Warior).WariorHeal();

                            break;
                    }
                    break;
                case "Друид":
                    Console.WriteLine("1 - ментальная атака (MP - 0)");
                    Console.WriteLine("2 - ростки отравления (MP - 10)");
                    Console.WriteLine($"3 - востановление 40 HP (MP - 40 MP)");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Holder.Hero.HeroAtack(Holder.Enemis[0]);

                            break;
                        case "2":
                            (Holder.Hero as Druid).DruidAttacKnight(Holder.Enemis[0]);

                            break;
                        case "3":
                            (Holder.Hero as Druid).DruidHeal();
                            break;
                    }
                    break;
                case "Паладин":
                    Console.WriteLine("1 - удар палицей (MP - 0)");
                    Console.WriteLine("2 - святое искаренение (MP - 10)");
                    Console.WriteLine($"3 - востановление всего HP (MP - {Holder.Hero.MP_Max} MP)");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Holder.Hero.HeroAtack(Holder.Enemis[0]);
                            break;
                        case "2":
                            (Holder.Hero as Paladin).DruidAttaLight(Holder.Enemis[0]);

                            break;
                        case "3":
                            (Holder.Hero as Paladin).PaladinHeal();
                            break;
                    }
                    break;
            }


        }


    }
}
