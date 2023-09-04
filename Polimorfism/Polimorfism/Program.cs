using System;
using System.Collections.Generic;

namespace Polimorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();

            List<Animal> animals = new List<Animal>();

            animals.Add(dog);
            animals.Add(cat);

            foreach(Animal animal in animals)
            {
                animal.Zgomot();
            }

        }
    }
}
