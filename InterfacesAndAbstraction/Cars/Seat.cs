using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Seat : ICar
{

    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
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

        sb.AppendLine($"{Color} {this.GetType().Name} {Model}");
        sb.AppendLine(this.Start());
        sb.AppendLine(this.Stop());

        return sb.ToString();
    }
}
