using System;
namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Sheep sheep = new Sheep();
            sheep.SleepSound();
            sheep.AnimalSound();
        }
    }
    abstract class Animal
    {
        public abstract void AnimalSound();
        public void SleepSound()
        {
            Console.WriteLine("Zzzzz");
        }
    }
    class Sheep : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Meeee meeee");
        }
    }
}