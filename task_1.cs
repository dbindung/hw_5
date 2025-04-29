using System;

class Task1
{
    public static void Run()
        {
            Animal dog = new Dog();
            Animal cat = new Cat();
            Animal cow = new Cow();

            dog.Speak();
            cat.Speak();
            cow.Speak();
        }
}

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Some generic animal sound");
    }
    public virtual string Type()
    {
        return "Generic Animal";
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }

    public override string Type()
    {
        return "Dog";
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow!");
    }
    public override string Type()
    {
        return "Cat";
    }
}

class Cow : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Moo!");
    }
    public override string Type()
    {
        return "Cow";
    }
}