using System;

namespace Common.Infrastructure.Seedwork.DI
{
    public interface IConfigurableContainer : IContainer
    {
        void RegisterSingleton(Type lookupType, object instance);

        void RegisterType(Type objectType, bool singleton, bool unitOfWorkScope);

        void RegisterType<T>(Func<IContainer, T> factoryMethod, bool singleton, bool unitOfWorkScope);

        void ConfigureType(Type objectType, string property, object value);

        void ConfigureType<TObjectType, TSourceType>(
            string propertyName,
            Func<TSourceType, object> valueExpression);
    }
}
