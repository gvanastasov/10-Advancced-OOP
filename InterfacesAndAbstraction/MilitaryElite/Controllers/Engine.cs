using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    private SoldierManager manager;
    private StringBuilder output;

    public Engine()
    {
        this.manager = new SoldierManager();
        this.output = new StringBuilder();
    }

    public void Run()
    {
        while (true)
        {
            var cmd = Console.ReadLine();

            if (cmd.ToLower() == "end")
            {
                break;
            }

            var cmdTokens = cmd.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            Execute(cmdTokens);
        }

        Console.WriteLine(output.ToString().Trim());
    }

    private void Execute(string[] tokens)
    {
        var id = tokens[1];
        var firstName = tokens[2];
        var lastName = tokens[3];
        double salary;
        string corps;
        string cmdResult = string.Empty;

        try
        {
            switch (tokens[0])
            {
                case "Private": // “Private <id> <firstName> <lastName> <salary>”
                    salary = double.Parse(tokens[4]);
                    cmdResult = this.manager.RegisterPrivate(id, firstName, lastName, salary);
                    break;
                case "LeutenantGeneral": // “LeutenantGeneral <id> <firstName> <lastName> <salary> <private1Id> <private2Id> … <privateNId>”
                    salary = double.Parse(tokens[4]);
                    cmdResult = this.manager.RegisterLeutenantGeneral(id, firstName, lastName, salary, tokens.Skip(5));
                    break;
                case "Engineer": // “Engineer <id> <firstName> <lastName> <salary> <corps> <repair1Part> <repair1Hours> … <repairNPart> <repairNHours>” 
                    salary = double.Parse(tokens[4]);
                    corps = tokens[5];
                    cmdResult = this.manager.RegisterEngineer(id, firstName, lastName, salary, corps, tokens.Skip(6).ToArray());
                    break;
                case "Commando": // “Commando <id> <firstName> <lastName> <salary> <corps> <mission1CodeName>  <mission1state> … <missionNCodeName> <missionNstate>”
                    salary = double.Parse(tokens[4]);
                    corps = tokens[5];
                    cmdResult = this.manager.RegisterCommando(id, firstName, lastName, salary, corps, tokens.Skip(6).ToArray());
                    break;
                case "Spy": // “Spy <id> <firstName> <lastName> <codeNumber>”
                    var codeNumber = int.Parse(tokens[4]);
                    cmdResult = this.manager.RegisterSpy(id, firstName, lastName, codeNumber);
                    break;
                default:
                    break;
            }

            this.output.AppendLine(cmdResult);
        }
        catch (ArgumentException)
        {
            return;
        }
    }
}
