using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Exercise
{
    public class Car
    {
        public Car(string makeInput, string modelInput, int yearInput)
        {
            this.Make = makeInput;
            this.Model = modelInput;
            this.Year = yearInput;
        }


        public Car()
        {

        }

         public string Make { get; set; }
         public string Model { get; set; }
         public int Year { get; set; }


        public void Honk ()
        {
            Console.WriteLine("Beep beep");
        } 
    }
}
    