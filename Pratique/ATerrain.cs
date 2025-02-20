namespace Pratique;

public abstract class ATerrain
{
    protected double CoutDeBase;
    protected Service[] Services = new Service[2];

    public ATerrain(Service[] services)
    {
        Services = services;
        CoutDeBase = 30;
    }

    public abstract double CalculerCout();
}
