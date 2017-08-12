using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AddCollection<T> : Collection<T>, IAddCollection<T>
{
    public virtual int Add(T input)
    {
        this.data.Add(input);
        return this.data.Count - 1;
    }
}
