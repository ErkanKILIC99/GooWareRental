using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using GooWareRental.BusinessLogicLayer.Abstracts;
using GooWareRental.BusinessLogicLayer.Concretes;
using GooWareRental.Core.Utilities.Interceptors;
using GooWareRental.Core.Utilities.Security.JasonWebToken;
using GooWareRental.DataAccessLayer.Abstracts;
using GooWareRental.DataAccessLayer.Concretes.EntityFramework;

namespace GooWareRental.BusinessLogicLayer.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();


            builder.RegisterType<EFColorDal>().As<IColorDal>().SingleInstance();
            builder.RegisterType<ColorManager>().As<IColorService>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
