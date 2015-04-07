using System;

namespace Common.Infrastructure.Seedwork.DI
{
    public interface IContainer : IDisposable
    {
        object Build(Type t);

        T Build<T>();
    }
}
