
namespace Pratique;

public class Service
{
    private double _cout;
    private bool _estActif;
    public Service(double cout, bool estActif)
    {
        _cout = cout;
        _estActif = estActif;
    }

    public double GetCout()
    {
        return _cout;
    }

    public bool GetEstActif()
    {
        return _estActif;
    }
}
