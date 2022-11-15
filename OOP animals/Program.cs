using OOP_animals;

Tiger tiger = new Tiger("Tiqr", 7);
tiger.ToEat("myaso", 5);
tiger.ToSound();
Horse horse = new Horse("Alex", 3, "4 km/s");
horse.ToEat("trava", 2);
horse.ToSound();

Console.WriteLine(tiger.ToEat("myaso", 5).Text);
Console.WriteLine(tiger.ToSound().Text);
Console.WriteLine(horse.ToEat("trava", 2).Text);
Console.WriteLine(horse.ToSound().Text);

Aviary forest = new Aviary("Forest", BiomType.Tropic,2,"10");
Tiger newTiger = new Tiger("Sim", 7);
Console.WriteLine(forest.AddAnimal(newTiger));

Aviary mountain = new Aviary("Mountain", BiomType.Jungle, 3, "20");
Horse newHorse = new Horse("Simba", 3,"3 km/c");
Console.WriteLine(mountain.AddAnimal(newHorse)); 











