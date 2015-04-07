using System;
using System.Collections.Generic;

namespace Common.Infrastructure.Seedwork.DI
{
    public interface IContainer : IDisposable
    {
        /// <summary>
        /// Build an object of the specified <paramref name="t">type</paramref>.
        /// </summary>
        /// <param name="t"></param>
        /// <returns>
        /// An object of type <paramref name="t"/> or <c>null</c> if <paramref name="t"/> is 
        /// no registered type is assignable to <paramref name="t"/>.
        /// </returns>
        /// <seealso cref="Build{t}"/>
        object Build(Type t);

        T Build<T>();

        IEnumerable<object> BuildAll(Type t);

        IEnumerable<T> BuildAll<T>();

        IContainer BuildChildContainer();

        /// <summary>
        /// Wires the dependencies on the <paramref name="instance"/> using property injection.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        object BuildObject(object instance);

        /// <summary>
        /// Returns <c>true</c> if the specified <paramref name="t">type</paramref> is registered with
        /// the container.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool HasType(Type t);
    }
}
