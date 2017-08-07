using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tesla : ICar, IElectricCar
{

    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }

    private int battery;
    public int Battery
    {
        get
        {
            return this.battery;
        }

        set
        {
            this.battery = value;
        }
    }

    private string color;
    public string Color
    {
        get
        {
            return this.color;
        }

        set
        {
            this.color = value;
        }
    }

    private string model;
    public string Model
    {
        get
        {
            return this.model;
        }

        set
        {
            this.model = value;
        }
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{Color} {this.GetType().Name} {Model} with {Battery} Batteries");
        sb.AppendLine(this.Start());
        sb.AppendLine(this.Stop());

        return sb.ToString();
    }
}
