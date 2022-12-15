using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public int SafetyRating { get; set; }

        public int NumberOfCupHolders { get; set; }
        public int GasMileage { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
        public int Year { get ; set ; }
        public string Logo { get ; set ; }
        public string Name { get ; set ; }
    }
}
