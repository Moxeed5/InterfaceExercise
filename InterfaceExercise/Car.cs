using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        //public override void GoOnTrip()
        //{
           // Console.WriteLine("We're in a car");
       // }
        public int NumberofDoorss { get; set; }

        public bool RegularGas { get; set; }
        public int GasMileage { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
        public int Year { get ; set ; }
        public string Logo { get ; set ; }
        public string Name { get ; set ; }
    }
}
