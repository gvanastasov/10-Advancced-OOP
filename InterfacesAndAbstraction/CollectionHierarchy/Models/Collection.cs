using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Collection<T>
{
    public Collection()
    {
        this.data = new List<T>();
    }

    protected List<T> data;
}
