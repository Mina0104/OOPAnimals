using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_animals
{
    public class Horse : AbstactAnimal
    {
        
        public string Speed { get; set; }
        public Horse (string name, int age,string speed) : base(name, age)
        {
            Name = name;
            Age = age;
            Biome = BiomType.Forest;
            Eat = new string[] { "trava" };
            _sound = "hihahiha";
            IsPradator = false;
            Speed = speed;
            Species = "Horse";

        }
        
      
        public Message ToEat(string eat, int kg)
        {
            return new Message()
            {
                Text = $"{Name} poel {kg} kilogramma {eat} ",
                SenderName = this.Name,
                MessageType = MessageType.Eat,
            };

        }
        public Message ToSound()
        {
            return new Message()
            {
                Text = $"{Name} izdaet zvuki {_sound}",
                SenderName = this.Name,
                MessageType = MessageType.Sound,
            };
        }
        public Message ToRun()
        {
            return new Message()
            {
                Text = $"{Name} beqayet {Speed}",
                SenderName = this.Name,
                MessageType = MessageType.Run
            };
        }
    }
}
