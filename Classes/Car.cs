using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {

        public Car ()
        {

        }

        //Special member method, same name as it's class.
        //Create a make property that is of type string.
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        
        public string Make { get; set; } //get = read, and set = write. 
        public string Model { get; set; } //These 3 lines make and define Car. 
        public int Year { get; set; }
    }
   
}
