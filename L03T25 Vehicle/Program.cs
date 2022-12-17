using System.Collections;
using System.Collections.Generic;

class Vehcile  // base class (parent) 
{
    public string brand;  // Vehicle field
    public string model;

}

class Tires : Vehcile  // derived class (child)
{
    public string manufacturer; // Car field
    public string modelTires;
    public string TireSize;
}

class Program
{
    static void Main(string[] args)
    {
        List<string> mytires = new List<string>();

        // Create a myCar object
        Tires myCar = new Tires();
        Tires myCar1 = new Tires();
        // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
        myCar.brand = "Posche";
        myCar.model = "911";
        myCar.manufacturer = "Nokia";
        myCar.modelTires = "Hakkapeliitta";
        myCar.TireSize = "205R16";
        Console.WriteLine("Created a new vechile" + myCar.brand + " model: " + myCar.model);

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Tire: " + myCar.manufacturer + " added to vechile: " + myCar.brand);


        }

        mytires.Add(myCar.manufacturer);
        mytires.Add(myCar.brand);
        mytires.Add(myCar.modelTires);
        mytires.Add(myCar.TireSize);
        Console.WriteLine("Vehicle Name: " + myCar.brand + " Model: " + myCar.model + " has tires: ");
        foreach (string a in mytires)
        {

            Console.WriteLine("-Name: " + myCar.manufacturer + " Model: " + myCar.modelTires + " TiresSize: " + myCar.TireSize);
        }
        myCar1.brand = "Ducati";
        myCar1.model = "Diavel";
        myCar1.manufacturer = "MIC";
        myCar1.modelTires = "Pilot";
        myCar1.TireSize = "160R16";
        Console.WriteLine("Created a new vechile" + myCar.brand + "model" + myCar.model);
        for (int n = 0; n < 2; n++)
        {
            Console.WriteLine("Tire: " + myCar1.manufacturer + " added to vechile: " + myCar1.brand);

        }

        string[] mytires1 = { myCar1.model, myCar1.manufacturer, myCar1.brand, myCar1.modelTires, myCar1.TireSize };
        Console.WriteLine("Vehicle Name: " + myCar1.brand + " Model: " + myCar1.model + " tires: ");
        foreach (string j in mytires1)
        {

            Console.WriteLine("-Name: " + myCar1.manufacturer + " Model: " + myCar1.modelTires + " TiresSize: " + myCar1.TireSize);
        }







    }
}