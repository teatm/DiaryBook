using Autofac;
using Autofac.Extensions.DependencyInjection;
using DiaryBook.BusinessLogic.Bootstrap;
using DiaryBook.Repositories.Bootstrap;
using DiaryBook.Services.Bootstrap;
using DiaryBook.UnitOfWork.Bootstrap;
using Microsoft.Extensions.DependencyInjection;

namespace DiaryBook.Bootstrap
{
    public static class Bootstrapper
    {
        public static IContainer Bootstrap(IServiceCollection services)
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new PresentationModule());
            builder.RegisterModule(new ServicesModule());
            builder.RegisterModule(new BusinessLogicModule());
            builder.RegisterModule(new RepositoriesModule());
            builder.RegisterModule(new UnitOfWorkModule());

            builder.Populate(services);
            var container = builder.Build();

            return container;
        }
    }
}
