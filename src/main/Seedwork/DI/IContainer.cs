using System;
using System.Collections.Generic;

namespace Common.Infrastructure.Seedwork.DI
{
    public interface IContainer : IDisposable
    {
        object Build(Type t);

        T Build<T>();

        IEnumerable<object> BuildAll(Type t);

        IEnumerable<T> BuildAll<T>();

        IContainer BuildChildContainer();

        object BuildObject(object instance);

        bool HasType(Type t);
    }
}
