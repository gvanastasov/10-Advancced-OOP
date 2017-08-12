using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Private : Soldier, IPrivate
{
    public Private(string id, string firstName, string lastName, double salary) : base(id, firstName, lastName)
    {
        this.Salary = salary;
    }

    private double salary;
    public double Salary
    {
        get
        {
            return this.salary;
        }
        set
        {
            this.salary = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $" Salary: {Salary:f2}"; 
    }
}
