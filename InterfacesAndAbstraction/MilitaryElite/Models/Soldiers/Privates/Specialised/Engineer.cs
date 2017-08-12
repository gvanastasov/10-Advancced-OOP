using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(string id, string firstName, string lastName, double salary, string corps, List<IRepair> repairs) 
        : base(id, firstName, lastName, salary, corps)
    {
        this.repairs = repairs;
    }

    private List<IRepair> repairs;
    public IReadOnlyList<IRepair> Repairs
    {
        get
        {
            return this.repairs;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(base.ToString());
        sb.AppendLine("Repairs:");
        foreach (var p in Repairs)
        {
            sb.AppendLine("  " + p.ToString());
        }

        return sb.ToString().Trim();
    }
}
