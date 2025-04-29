using System;

class Task2
{
    public static void Run()
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog(),
                new Cat(),
                new Cow()
            };

            foreach (Animal animal in animals)
            {
                animal.Speak();
            }
        }
}
