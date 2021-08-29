using Autofac;
using LostAnimals.Core.Interfaces;
using LostAnimals.Core.Services;

namespace LostAnimals.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}
