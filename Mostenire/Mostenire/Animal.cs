using System;
using System.Collections.Generic;
using System.Text;

namespace Mostenire
{
    class Animal
    {
        public virtual void Mergi()
        {
            Console.WriteLine("A inceput sa mearga..");
        }

        public virtual void Zgomot()
        {
            Console.WriteLine("Face un zgomot specific..");
        }
    }
}
