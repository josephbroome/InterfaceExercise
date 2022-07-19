using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car: IVehicle
    {
        public Car()
        {

        }
        public Car(double trunksize, bool fwd)
        {
           TrunkSize = trunksize;
            FWD = fwd;
        }
   
        public double TrunkSize { get; set; }
        public bool FWD { get; set; }
        public string Logo { get ; set ; }
        public string Name { get ; set ; }
        public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool UsesGass { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MPG { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
