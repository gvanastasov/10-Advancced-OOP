using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Robot : IIdentifiable
{
    public Robot(string model, string id)
    {
        this.Model = model;
        this.id = id;
    }

    private string model;
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }

    private string id;
    public string Id
    {
        get
        {
            return this.id;
        }
    }
}
