class Auto
{
    public sealed void Display()
    {
        Console.WriteLine("Auto");
    }
}
class Truck : Auto
{
 public void DisplayInfo()
 {
 base.Display();
 }
}
class Program
{
 static void Main(string[] args)
 {
 Truck truck = new Truck();
 truck.DisplayInfo();
 Console.ReadKey();
 }
}