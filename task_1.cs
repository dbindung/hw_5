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
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow!");
    }
}

class Cow : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Moo!");
    }
}