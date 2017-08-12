using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pet : IBirthable
{
    public Pet(string name, string birthdate)
    {
        this.Name = name;
        this.birthdata = birthdate;
    }

    private string name;
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    private string birthdata;
    public string Birthdate
    {
        get
        {
            return this.birthdata;
        }
    }
}
