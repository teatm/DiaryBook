using Autofac;
using Autofac.Integration.Mvc;
using DiaryBook.Controllers;

namespace DiaryBook.Bootstrap
{
    public class PresentationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterControllers(typeof(Startup).Assembly);
            builder.RegisterType<HomeController>().InstancePerRequest();
        }
    }
}
