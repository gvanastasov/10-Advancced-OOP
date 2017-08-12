using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    public Engine()
    {
        this.output = new StringBuilder();
    }

    private StringBuilder output;

    public void Run()
    {
        while (true)
        {
            var cmd = Console.ReadLine();

            if(cmd.ToLower() == "end")
            {
                break;
            }

            Execute(cmd);
        }

        Console.WriteLine(output.ToString().Trim());
    }

    private void Execute(string cmd)
    {
        var tokens = cmd.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        var citizen = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));

        output.AppendLine(((IPerson)citizen).GetName());
        output.AppendLine(((IResident)citizen).GetName());
    }
}
