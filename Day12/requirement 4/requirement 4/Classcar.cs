using System;

public abstract class Car

{

    public long Id { get; set; }

    public string Name { get; set; }

    // Abstract method for calculating drive cost

    public abstract double CalculateDriveCost(double km);

}