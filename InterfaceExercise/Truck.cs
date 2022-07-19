using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck: ICompany, IVehicle
    {
        public void IVehicle(int wheels, bool usesGass, int doors, double mpg)
        {
           Wheels = wheels;
            UsesGass = usesGass;
            Doors = doors;
             MPG = mpg;


        }
        public void ICompany(string logo,string name)
        {
            Logo = logo;
            Name= name; 
        }
        public Truck()
        {

        }
      
        public Truck (int bedsize, int towingcapcity)
        {
            BedSize = bedsize;
            TowingCapacity= towingcapcity;
        }
        public int BedSize { get; set; }
        public int TowingCapacity { get; set; }
        public string Logo { get; set ; }
        public string Name { get ; set ; }
        public int Wheels { get ; set; }
        public bool UsesGass { get; set ; }
        public int Doors { get ; set ; }
        public double MPG { get; set; }
    }
}
