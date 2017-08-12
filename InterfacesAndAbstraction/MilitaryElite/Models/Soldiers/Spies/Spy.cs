using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Spy : Soldier, ISpy
{
    public Spy(string id, string firstName, string lastName, int codeNumber) 
        : base(id, firstName, lastName)
    {
        this.CodeNumber = codeNumber;
    }

    private int codeNumber;
    public int CodeNumber
    {
        get
        {
            return this.codeNumber;
        }
        set
        {
            this.codeNumber = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + Environment.NewLine + $"Code Number: {CodeNumber}";
    }
}
