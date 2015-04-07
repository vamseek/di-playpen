namespace Common.Infrastructure.Seedwork.DI
{
    public interface IConfigurableContainer : IContainer
    {
        void RegisterSingleton(object obj);


    }
}
