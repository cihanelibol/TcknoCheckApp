using Autofac;
using TcknoCheckApp.BusinessLogic.Abstract;
using TcknoCheckApp.BusinessLogic.Concrete;
using TcknoCheckApp.Controllers;
using TcknoCheckApp.DataAccess.Abstract;
using TcknoCheckApp.DataAccess.Concrete;

namespace TcknoCheckApp.BusinessLogic.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<PortalManager>().As<IPortalManager>();
            builder.RegisterType<EfPortalDal>().As<IPortalDal>();


            builder.RegisterType<StarbuckManager>().As<IStarbuckManager>();
            builder.RegisterType<EfStarbuckDal>().As<IStarbuckDal>();
        }
    }
}
