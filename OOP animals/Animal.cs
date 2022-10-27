using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_animals
{
    public class Animal
    {
        public string Name { get; protected set; }
        public BiomType Biome { get; protected set; }
        public string[] Eat { get; set; }
        public int Age { get; set; }
        public bool IsPradator { get; protected set; }
        protected string _sound;
        public Animal (string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void ToEat (string eat, int kg)
        {
            Console.WriteLine($"{Name} poel {kg} kilogramma {eat} ");
        }
        public void ToSound()
        {
            Console.WriteLine($"{Name} izdaet zvuki {_sound}");

        }
    }
}
