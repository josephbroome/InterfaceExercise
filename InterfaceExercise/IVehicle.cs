using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle: ICompany
    {
        
        public int Wheels { get; set; }
        public bool UsesGass { get; set; }
        public int Doors { get; set; }
        public double MPG { get; set; }
        bool TowingCapacity { get; set; }
    }
}
