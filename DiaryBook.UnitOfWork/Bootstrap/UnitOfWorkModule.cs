using Autofac;
using DiaryBook.Contracts.UnitOfWork;

namespace DiaryBook.UnitOfWork.Bootstrap
{
    public class UnitOfWorkModule : Module
    {
        public UnitOfWorkModule()
        {
        }

        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterAssemblyTypes(ThisAssembly)
            //    .Where(m => m.Name.EndsWith("UnitOfWork"))
            //    .AsImplementedInterfaces()
            //    .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        }
    }
}
