using Autofac;
using DiaryBook.Contracts.Services;

namespace DiaryBook.Services.Bootstrap
{
    public class ServicesModule : Module
    {
        public ServicesModule()
        {
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(m => m.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
