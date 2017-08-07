using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ferrari : ICar
{
    public Ferrari(string driver)
    {
        this.Driver = driver;
    }

    public string Model { get { return "488-Spider"; } }
    public string Driver { get; private set; }

    public string UseBrakes()
    {
        return "Brakes!";
    }

    public string PushTheGasPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{Model}/{UseBrakes()}/{PushTheGasPedal()}/{Driver}";
    }
}
