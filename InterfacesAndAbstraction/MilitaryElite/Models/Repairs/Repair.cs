using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Repair : IRepair
{
    public Repair(string partName, int hoursWorked)
    {
        this.PartName = partName;
        this.hoursWorked = hoursWorked;
    }
    
    private string partName;
    public string PartName
    {
        get
        {
            return this.partName;
        }
        set
        {
            this.partName = value;
        }
    }

    private int hoursWorked;
    public int HoursWorked
    {
        get
        {
            return this.hoursWorked;
        }
        set
        {
            this.hoursWorked = value;
        }
    }

    public override string ToString()
    {
        return $"Part Name: {PartName} Hours Worked: {HoursWorked}";
    }
}
