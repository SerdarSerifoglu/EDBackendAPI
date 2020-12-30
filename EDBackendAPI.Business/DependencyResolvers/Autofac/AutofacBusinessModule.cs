using Autofac;
using Autofac.Extras.DynamicProxy;
using EDBackendAPI.Business.Abstract;
using EDBackendAPI.Business.Concrete;
using EDBackendAPI.Core.Utilities.Security.Jwt;
using EDBackendAPI.DataAccess.Abstract;
using EDBackendAPI.DataAccess.Concrete.EntityFramework;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;
using EDBackendAPI.Core.Utilities.Interceptors.Autofac;

namespace EDBackendAPI.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthService>().As<IAuthService>();
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
