using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AddRemoveCollection<T> : AddCollection<T>, IAddRemoveCollection<T>
{
    public override int Add(T input)
    {
        this.data.Insert(0, input);
        return 0;
    }

    public virtual T Remove()
    {
        var lastIndex = this.data.Count - 1;

        var entity = this.data[lastIndex];
        this.data.RemoveAt(lastIndex);

        return entity;
    }
}
