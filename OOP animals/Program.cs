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












