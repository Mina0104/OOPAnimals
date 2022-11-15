using NUnit.Framework;
using OOP_animals;


namespace ZooparkTest

{
    public class AviaryTests
    {
        [TestCaseSource(typeof(AddAnimaTestsSource))]
        public void AddAnimalTests(AbstactAnimal animal,Aviary aviary, Aviary expectedAviary, Message expectedMessage)
        {
            Message actualMessage = aviary.AddAnimal(animal);
            Aviary actualAviary = aviary;
            //Assert.AreEqual(expectedAviary, actualAviary);
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}