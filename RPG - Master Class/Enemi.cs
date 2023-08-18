using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPG___Master_Class
{
    public class Enemi
    {
        public int HP { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }

        public Enemi( )
        {
            this.HP = 1;
            this.Damage = 1;
            this.Name = "Враг";

        }
        public Enemi(int hp)
        {
            this.HP = hp;
            this.Damage = 1;
            this.Name = "Враг";

        }
        public Enemi(int hp, int damage)
        {
            this.HP = hp;
            this.Damage = damage;
            this.Name = "Враг";

        }
        public Enemi(int hp, int damage, string name)
        {
            this.HP = hp;
            this.Damage = damage;
            this.Name = name;

        }
        public virtual void EnemiAttac(Hero hero)
        {
            hero.HeroAimAttack(this.Damage);
        }
        public virtual void EnemiAimAttac(int damage)
        {
            this.HP -= damage;
            if (this.HP <= 0)
            {
                EnemiDestrou();
            }

        }
        public void EnemiDestrou()
        {
            Holder.Hero.LevelUp();
            Console.Clear();
            Console.WriteLine("НОВЫЙ УРОВЕНЬ!!!");
            Thread.Sleep(3000);
            Console.Clear();
            Holder.Enemis.Remove(Holder.Enemis[0]);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{this.Name} - HP({this.HP})");
        }



    }



    public class EnemiSlime : Enemi
    {

        public EnemiSlime(int hp, int damage, string name)
        {
            base.HP = hp;
            base.Damage = damage;
            base.Name = name;
        }



     
    }

    public class EnemiSkilet : Enemi
    {

        public EnemiSkilet(int hp, int damage, string name)
        {
            base.HP = hp;
            base.Damage = damage;
            base.Name = name;
        }

        
    }

    public class EnemiSpider : Enemi
    {

        public EnemiSpider(int hp, int damage, string name)
        {
            base.HP = hp;
            base.Damage = damage;
            base.Name = name;
        }

      
    }
}
