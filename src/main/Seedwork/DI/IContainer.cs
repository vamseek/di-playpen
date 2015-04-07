using System;

namespace Common.Infrastructure.Seedwork.DI
{
    public interface IContainer
    {
        object Build(Type t);

        T Build<T>();
    }
}
