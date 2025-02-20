namespace Pratique;

public class TerrainSauvage : ATerrain
{
    public TerrainSauvage(Service[] services) : base(services)
    {
    }

    public override double CalculerCout()
    {
        double total = CoutDeBase;
        double min = int.MaxValue;
        for (int i = 0; i < Services.Length; i++)
        {
            if (Services[i].GetEstActif() && min > Services[i].GetCout())
            {
                min = Services[i].GetCout();
            }
        }

        // si on ne choisi aucun des services, min sera = à max value
        if (min != int.MaxValue)
        {
            total += min;
        }
        return total;
    }
}
