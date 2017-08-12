using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyList<T> : AddRemoveCollection<T>, IMyList<T>
{
    public override T Remove()
    {
        var entity = this.data[0];
        this.data.RemoveAt(0);

        return entity;
    }

    public IReadOnlyList<T> Used
    {
        get
        {
            return this.data;
        }
    }
}
