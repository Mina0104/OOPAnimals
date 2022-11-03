using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_animals
{
    public class Horse : AbstactAnimal
    {
        public string Name { get; protected set; }
        public BiomType Biome { get; protected set; }
        public string[] Eat { get; set; }
        public int Age { get; set; }
        public bool IsPradator { get; protected set; }
        protected string _sound;
        public string Run { get; set; }
        public Horse (string name, int age,string run) : base(name, age)
        {
            Name = name;
            Age = age;
            Biome = BiomType.Forest;
            Eat = new string[] { "trava" };
            _sound = "hihahiha";
            IsPradator = false;
            Run = run;

        }
        
      
        public Message ToEat(string eat, int kg)
        {
            return new Message()
            {
                Text = $"{Name} poel {kg} kilogramma {eat} ",
                Name = this.Name,
                MessageType = MessageType.Eat,
            };

        }
        public Message ToSound()
        {
            return new Message()
            {
                Text = $"{Name} izdaet zvuki {_sound}",
                Name = this.Name,
                MessageType = MessageType.Sound,
            };
        }
        public Message ToRun()
        {
            return new Message()
            {
                Text = $"{Name} beqayet {Run}",
                Name = this.Name,
                MessageType = MessageType.Run
            };
        }
    }
}
