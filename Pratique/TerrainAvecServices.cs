namespace Pratique;

public class TerrainAvecServices : ATerrain
{
    public TerrainAvecServices(Service[] services) : base(services)
    {

    }


    public override double CalculerCout()
    {
        double total = CoutDeBase;
        for (int i = 0; i < Services.Length; i++)
        {
            if (Services[i].GetEstActif())
            {
                total += Services[i].GetCout();
            }
        }
        return total;
    }
}
