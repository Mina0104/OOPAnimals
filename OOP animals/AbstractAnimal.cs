using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_animals
{
    public abstract class AbstactAnimal
    {
        public string Name { get; protected set; }
        public BiomType Biome { get; protected set; }
        public string[] Eat { get; set; }
        public int Age { get; set; }
        public string Square { get; set; }
        public string Species { get; set; }
        public bool IsPradator { get; protected set; }
        protected string _sound;
        public AbstactAnimal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public  Message ToEat(string eat, int kg)
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

        

        }


    }










