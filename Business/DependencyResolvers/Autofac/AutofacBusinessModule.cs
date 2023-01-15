using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OgrenciManager>().As<IOgrenciService>().SingleInstance();
            builder.RegisterType<EfOgrenciDal>().As<IOgrenciDal>().SingleInstance();
            builder.RegisterType<TurManager>().As<ITurService>().SingleInstance();
            builder.RegisterType<EfTurDal>().As<ITurDal>().SingleInstance();
            builder.RegisterType<KitapManager>().As<IKitapService>().SingleInstance();
            builder.RegisterType<EfKitapDal>().As<IKitapDal>().SingleInstance();
            builder.RegisterType<YazarManager>().As<IYazarService>().SingleInstance();
            builder.RegisterType<EfYazarDal>().As<IYazarDal>().SingleInstance();
            builder.RegisterType<EmanetManager>().As<IEmanetService>().SingleInstance();
            builder.RegisterType<EfEmanetDal>().As<IEmanetDal>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<FileHelperManager>().As<IFileHelper>().SingleInstance();
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                   .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                   {
                       Selector = new AspectInterceptorSelector()
                   }).SingleInstance();


        }

    }
}