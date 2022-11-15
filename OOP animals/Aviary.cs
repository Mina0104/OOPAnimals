namespace OOP_animals


{
    public class Aviary
    {
        public string Name { get; protected set; }
        public BiomType Biome { get; protected set; }
        public int Age { get; set; }
        public string Square { get; set; }



        public List<AbstactAnimal> Animals { get; protected set; }
        public object SenderName { get; private set; }
        public object SenderType { get; private set; }

        public Aviary(string name, BiomType biome, int age, string square)
        {
            Name = name;
            Biome=biome;
            Age = age;
            Square = square;
            Animals = new List<AbstactAnimal>();
        }

        public Message AddAnimal(AbstactAnimal animal)
        {
            if (Biome != animal.Biome)
            {
                return new Message()
                {
                    Text = $"{Name} ne poselilsya {animal.Name} ne podxodit Biom",
                    SenderName = Name,
                    SenderType = "Aviary",
                    MessageType = MessageType.AddAnimalFail


                };
            }
            else if (!Sosedi(animal))
            {
                return new Message()
                {
                    Text = $"{Name} ne poselilsya {animal.Species} iz-za sosedey",
                    SenderName = Name,
                    SenderType = "Aviary",
                    MessageType =MessageType.AddAnimalFail
                };
            }
            else
            {
                Animals.Add(animal);
                return new Message()
                {
                    Text = $"{Name} poselilsya {animal.Name}",
                    SenderName= Name,
                    SenderType = "Aviary",
                    MessageType =MessageType.AddAnimalSuccess

                };
            }
        }
            
            
            


        private bool Sosedi(AbstactAnimal animal)
        {
            foreach (AbstactAnimal c in Animals)
            {
                if ((c.IsPradator || animal.IsPradator) && c.Species != animal.Species)
                {
                    return false;
                }
            }
            return true;
        }

        public override bool Equals(object? obj)
        {
            return obj is Aviary aviary &&
                   Name == aviary.Name &&
                   Biome == aviary.Biome &&
                   Age == aviary.Age &&
                   Square == aviary.Square &&
                   Animals.Count == aviary.Animals.Count;
        }
    }
}

