﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMyList<T> : IAddRemoveCollection<T>
{
    IReadOnlyList<T> Used { get; }
}
