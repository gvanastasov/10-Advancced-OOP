using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Commando : SpecialisedSoldier, ICommando
{


    public Commando(string id, string firstName, string lastName, double salary, string corps, List<IMission> missions) 
        : base(id, firstName, lastName, salary, corps)
    {
        this.missions = missions;
    }

    private List<IMission> missions;
    public IReadOnlyList<IMission> Missions
    {
        get
        {
            return this.missions;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(base.ToString().Trim());
        sb.AppendLine("Missions:");
        foreach (var m in Missions)
        {
            sb.AppendLine("  " + m.ToString());
        }

        return sb.ToString().Trim();
    }
}
