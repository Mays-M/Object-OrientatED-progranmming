using System.Collections;
using System.Collections.Generic;

class Car  // base class (parent) 
{
    public string brand;  // Vehicle field
    public string model;
    public readonly int TireNumber= 265689;
    public readonly int [] tires = {20,40,60};
}

class Tires: Car  // derived class (child)
{
    public string manufacturer; // Car field
    public string modelTires;
    public string TireSize ;
}

class Program
{
    static void Main(string[] args)
    {
        // Create a myCar object
        Tires myCar = new Tires();
        Tires myCar1 = new Tires();
        Tires myCar2 = new Tires();

        // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
        myCar.brand = "Volvo";
        myCar.model = "volvo s202";
        myCar1.brand = "Hondai";
        myCar1.model = "Hondi 11";
        myCar2.brand = "Seat";
        myCar2.model = "seat valon2";
        myCar.manufacturer = "Germany";
        myCar.modelTires = "Flat";
        myCar.TireSize = "205/45R16";
        myCar1.manufacturer = "franch";
        myCar1.modelTires = "staded";
        myCar1.TireSize = "505/46R16";

        myCar2.manufacturer = "Finland";
        myCar2.modelTires = "Flat";
        myCar2.TireSize = "405/65R76";
        Console.WriteLine("Car brand: " + myCar.brand + " Car Model: " + myCar.model + " Car Tires number: " + myCar.TireNumber +
            " Car Tire sizes: " + myCar.tires[0]
            + " Tires Manufacturer: " + myCar.manufacturer + " Tire Model: " + myCar.modelTires + " Tire size: " + myCar.TireSize) ;

        Console.WriteLine("Car brand: " + myCar1.brand + " Car Model: " + myCar1.model + " Car Tires number: "
            + myCar1.TireNumber + " Car Tire sizes: " + myCar1.tires[1]
             + " Tires Manufacturer: " + myCar1.manufacturer + " Tire Model: " 
             + myCar1.modelTires + " Tire size: " + myCar1.TireSize);

        Console.WriteLine("Car brand: " + myCar2.brand + " Car Model: " + myCar2.model + " Car Tires number: " 
            + myCar2.TireNumber + " Car Tire sizes: " + myCar2.tires[2]
                   + " Tires Manufacturer: " + myCar2.manufacturer + " Tire Model: " + myCar2.modelTires +
                   " Tire size: " + myCar2.TireSize);




    }
}