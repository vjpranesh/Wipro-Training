using System;

abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    protected Animal (string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void MakeSound();
    public virtual void Feed()
    {
        Console.WriteLine($"{Name} is feeding. (Feeding the animal)");
    }
}

class Lion : Animal
{
    public Lion(string name, int age) : base(name, age) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} roars loudly");

    }
}

class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} trumpets ");
    }

}

class Monkey : Animal
{
    public Monkey (string name, int age) : base (name, age) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} chatters");
    }
}


class Zoo
{
    private List<Animal> animals = new List<Animal>();
    public void AddAnimal (Animal animal)
    {
        animals.Add(animal);
    }

    public void PerformAnimalActions()
    {
        Console.WriteLine("Zoo Activities:");
        foreach ( var animal in animals)
        {
            animal.MakeSound();
            animal.Feed();
            Console.WriteLine();
        }
    }
}
class Program
{
    static void Main()
    {
        Zoo zoo = new Zoo();
        zoo.AddAnimal(new Lion("Mufasa", 2));
        zoo.AddAnimal(new Elephant("Jumbo", 5));
        zoo.AddAnimal(new Monkey("Raja", 4));

        zoo.PerformAnimalActions();
    }
}