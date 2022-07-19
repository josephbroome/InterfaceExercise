using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
   public class SUV: ICompany, IVehicle
    {
        public int CargoHoldSize { get; set; }

        public bool AWD { get; set; }
        public string Logo { get ; set ; }
        public string Name { get ; set ; }
        public int Wheels { get; set ; }
        public bool UsesGass { get ; set ; }
        public int Doors { get ; set ; }
        public double MPG { get; set; }
    }
}
