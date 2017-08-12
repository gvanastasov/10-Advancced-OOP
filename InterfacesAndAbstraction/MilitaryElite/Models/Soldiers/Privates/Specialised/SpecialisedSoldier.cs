using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    public SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }

    private static readonly string[] possibleCorps = new string[] { "Airforces", "Marines" };

    private string corps;
    public string Corps
    {
        get
        {
            return this.corps;
        }
        set
        {
            if(possibleCorps.Contains(value) == false)
            {
                throw new ArgumentException("Invalid Corps");
            }

            this.corps = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(base.ToString());
        sb.AppendLine($"Corps: {this.corps}");

        return sb.ToString().Trim();
    }
}
