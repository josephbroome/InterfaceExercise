using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class CarLot: IEnumerable
    { 

        public List<Truck> CarList { get; set; } = new List<Truck>();
       
        public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool UsesGass { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MPG { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
