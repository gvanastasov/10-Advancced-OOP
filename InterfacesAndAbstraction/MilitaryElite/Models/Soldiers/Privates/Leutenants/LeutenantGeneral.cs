using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public LeutenantGeneral(string id, string firstName, string lastName, double salary, List<IPrivate> privates) : base(id, firstName, lastName, salary)
    {
        this.privates = privates;
    }

    private List<IPrivate> privates;

    public IReadOnlyList<IPrivate> Privates
    {
        get
        {
            return this.privates;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(base.ToString());
        sb.AppendLine("Privates:");

        foreach (var p in privates)
        {
            sb.AppendLine("\t" + p.ToString());
        }

        return sb.ToString().Trim();
    }
}
