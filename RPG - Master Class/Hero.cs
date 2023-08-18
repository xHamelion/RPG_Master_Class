using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPG___Master_Class
{
    public class Hero
    {
        public  int Level { get; set; }
        public  String Name { get; set; }
        public  String Class { get; set; }
        public int MP { get; set; }
        public int MP_Max { get; set; }
        public  int HP { get; set; }
        public  int HP_Max { get; set; }
        public  int Damage { get; set; }


        public  Hero()
        {
            this.Name = "Дурак без имени";
            this.Level = 1;
            this.HP_Max = 100;
            this.HP = this.HP_Max;
            this.Damage = 10;
        }
        public Hero(string name)
        {
            this.Name = name;
            this.Level = 1;
            this.HP_Max = 100;
            this.HP = this.HP_Max;
            this.Damage = 10;
        }
        public Hero(string name, int hp)
        {
            this.Name = name;
            this.Level = 1;
            this.HP_Max = hp;
            this.HP = this.HP_Max;
            this.Damage = 10;
        }

        public void DeadHero()
        {
            Console.Clear();
            Console.WriteLine("ВЫ МЕРТВЫ!!!");
            Thread.Sleep(7000);
            PlayerControlGame game = new PlayerControlGame();
            Console.Clear();
            game.Start();
        }

        public virtual void HeroAtack(Enemi enemi)
        {
            enemi.EnemiAimAttac(this.Damage);
        }
        public void RepairStats()
        {
            this.MP = MP_Max;
            this.HP = this.HP_Max;

        }
        public virtual void HeroAimAttack(int attcak)
        {
            this.HP -= attcak;
            if (this.HP <= 0)
                DeadHero();
        }

        public virtual void Info()
        {
            Console.WriteLine($"{Name} - HP({HP}), MP({MP}) - LVL({Level}) ");
        }

        public void LevelUp()
        {
            this.Level += 1;
            this.HP_Max += 20;
            this.MP_Max += 20;
            this.Damage += 5;
            this.MP = MP_Max;
            foreach (Enemi enemi in Holder.Enemis)
            {
                enemi.Damage += 5;
            }
        }

    }
    public class Warior:Hero
    {

        public void WariorAttacKnight(Enemi enemi)
        {
            if (base.MP >= 10)
            {
                enemi.EnemiAimAttac(this.Damage + Convert.ToInt32(this.Damage / 2));
            base.MP -= 10;
            }

        }

        public void WariorHeal()
        {
            if(base.MP >= 20)
            {
                base.HP += 20;
                base.MP -= 20;

            }
        }

        

        public Warior(string name, int hp)
        {
            base.Name = name;
            base.Level = 1;
            base.HP_Max = hp;
            base.HP = this.HP_Max;
            base.Damage = 12;
            base.Class = "Войн";
            base.MP_Max = 60;
            base.MP = MP_Max;
        }



    }

    public class Druid : Hero
    {

        public void DruidAttacKnight(Enemi enemi)
        {
            if (base.MP >= 10)
            {
                enemi.EnemiAimAttac(this.Damage + Convert.ToInt32(this.Damage / 2));
            base.MP -= 10;
            }

        }

        public void DruidHeal()
        {
            if (base.MP >= Convert.ToInt32(40 ))
            {
                base.HP += 40;
                base.MP -= Convert.ToInt32(40  );

            }
        }

        

        public Druid(string name, int hp)
        {
            base.Name = name;
            base.Level = 1;
            base.HP_Max = hp;
            base.HP = this.HP_Max;
            base.Damage = 8;
            base.Class = "Друид";
            base.MP_Max = 40;
            base.MP = base.MP_Max;
        }



    }

    public class Paladin : Hero
    {

        public void DruidAttaLight(Enemi enemi)
        {
            if (base.MP >= 10)
            {
                enemi.EnemiAimAttac(this.Damage + Convert.ToInt32(this.Damage / 2));
            base.MP -= 10;
            }

        }

        public void PaladinHeal()
        {
            if (base.MP >= Convert.ToInt32(base.MP_Max))
            {
                base.HP = base.HP_Max;

            base.MP -= Convert.ToInt32(base.MP_Max );
            }
        }

         

        public Paladin(string name, int hp)
        {
            base.Name = name;
            base.Level = 1;
            base.HP_Max = hp;
            base.HP = this.HP_Max;
            base.Damage = 10;
            base.Class = "Паладин";
            base.MP_Max = 50;
            base.MP = MP_Max;
        }


    }
}
