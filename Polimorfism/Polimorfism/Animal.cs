using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfism
{
    class Animal
    {

        public virtual void Alearga()
        {
            //test3
            Console.WriteLine("Animalul a inceput sa alerge");

        }

        public virtual void Zgomot()
        {
            Console.WriteLine("Animalul face un zgomot specific");
//modificare in main
        }

    }
}
