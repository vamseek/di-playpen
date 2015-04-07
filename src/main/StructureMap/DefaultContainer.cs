using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Infrastructure.Seedwork.DI;

namespace Common.Infrastructure.DI.StructureMap
{
    public class DefaultContainer : IConfigurableContainer
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public object Build(Type t)
        {
            throw new NotImplementedException();
        }

        public T Build<T>()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> BuildAll(Type t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> BuildAll<T>()
        {
            throw new NotImplementedException();
        }

        public IContainer BuildChildContainer()
        {
            throw new NotImplementedException();
        }

        public object BuildObject(object instance)
        {
            throw new NotImplementedException();
        }

        public bool HasType(Type t)
        {
            throw new NotImplementedException();
        }

        public void RegisterSingleton(Type lookupType, object instance)
        {
            throw new NotImplementedException();
        }

        public void RegisterType(Type objectType, bool singleton, bool unitOfWorkScope)
        {
            throw new NotImplementedException();
        }

        public void RegisterType<T>(Func<IContainer, T> factoryMethod, bool singleton, bool unitOfWorkScope)
        {
            throw new NotImplementedException();
        }

        public void ConfigureType(Type objectType, string property, object value)
        {
            throw new NotImplementedException();
        }

        public void ConfigureType<TObjectType, TSourceType>(string propertyName, Func<TSourceType, object> valueExpression)
        {
            throw new NotImplementedException();
        }
    }
}
