using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_animals
{
    public class Tiger :AbstactAnimal
    {
        public Tiger(string name, int age): base (name,age)
        {
            Biome = BiomType.Tropic;
            Eat = new string[] { "myaso" };
            _sound = "xxxxxx";
            Species = "Tiger";
        }
    }
}
