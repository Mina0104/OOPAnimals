using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_animals
{
    public class AddAnimaTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            Aviary aviary = new Aviary("Pasha", BiomType.Tropic, 10, "13");
            AbstactAnimal animal = new Tiger ("Somi", 1);

            Aviary expectedAviary = new Aviary("Pasha", BiomType.Tropic, 10, "13");
            expectedAviary.Animals.Add(new Tiger("Somi", 1));

            Message expectedMessage = new Message()
            {
                Text = $"{expectedAviary.Name} poselilsya {animal.Name}",
                SenderName = expectedAviary.Name,
                SenderType = "Aviary",
                MessageType = MessageType.AddAnimalSuccess
            };
            
            yield return new object[] {animal,aviary, expectedAviary,expectedMessage};
        }
    }
}

