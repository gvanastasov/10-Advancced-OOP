using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mission : IMission
{
    public Mission(string codeName, string state)
    {
        this.CodeName = codeName;
        this.State = state;
    }

    private static readonly string[] possibleStates = new string[] { "inProgress", "Finished" };

    private string codeName;
    public string CodeName
    {
        get
        {
            return this.codeName;
        }
        set
        {
            this.codeName = value;
        }
    }

    private string state;
    public string State
    {
        get
        {
            return this.state;
        }
        set
        {
            if(possibleStates.Contains(value) == false)
            {
                throw new ArgumentException("Invalid mission state");
            }

            this.state = value;
        }
    }

    public void CompleteMission()
    {
        this.state = "Finished";
    }

    public override string ToString()
    {
        return $"Code Name: {CodeName} State: {State}";
    }
}
