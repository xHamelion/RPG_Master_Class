using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG___Master_Class
{
    public static class Holder
    {
        public static Hero Hero { get; set; }
        public static List<Enemi> Enemis = new List<Enemi>();
    }
}
