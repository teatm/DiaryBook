using Autofac;

namespace DiaryBook.Repositories.Bootstrap
{
    public class RepositoriesModule : Module
    {
        public RepositoriesModule()
        {
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(m => m.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
