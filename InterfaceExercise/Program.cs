using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */
            var lot1 = new CarLot();

          
            Truck truck1 = new Truck(20, 100);
            truck1.IVehicle(4, true, 4, 15.6);
            truck1.ICompany("Ram", "Jeep");

           

         

            Console.WriteLine($"the {truck1.Name} with a {truck1.Logo} as a logo  has {truck1.Doors} doors. It is {truck1.UsesGass} that it uses gass and it gets {truck1.MPG} MPG ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            IVehicle truck2 = new Truck(20,1700);
         
            truck2.MPG = 26.2;
            truck2.Doors = 4;
            truck2.Wheels = 4;
            truck2.UsesGass = false;
            truck2.Name = "Chevy";
            truck2.Logo = "Raptor";
           

            Console.WriteLine($"the {truck2.Name} with a {truck2.Logo} as a logo  has {truck2.Doors} doors. It is {truck2.UsesGass} that it uses gass and it gets {truck2.MPG} MPG ");



            var truck3 = new Truck()
            {
                TowingCapacity = 250,
                BedSize = 30,
                UsesGass = true,
                MPG=20.7,
                Doors=4,
                Wheels=4,
                Logo="Falcon",
                Name="Birds of Prey"
                
                
             };

            lot1.CarList.Add(truck1);

            
         
          
            lot1.CarList.Add(truck3);

            //foreach(var vehicle in lot1.CarList)
            //{
            //    Console.WriteLine(vehicle.TowingCapacity);
            //}


            var carlot = new List<IVehicle>();

            carlot.Add(truck3);
            carlot.Add(truck2);
            carlot.Add(truck3);

          foreach( var vehicle in carlot)
            {
                Console.WriteLine(vehicle.Name);
                Console.WriteLine(vehicle.Logo);
                Console.WriteLine(truck1.BedSize);
                Console.WriteLine(truck2.TowingCapacity);
                
            }


            
            


            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
