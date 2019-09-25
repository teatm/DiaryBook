using Autofac;

namespace DiaryBook.BusinessLogic.Bootstrap
{
    public class BusinessLogicModule : Module
    {
        public BusinessLogicModule()
        {
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(m => m.Name.EndsWith("BusinessLogic"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
