using Autofac;
using EDBackendAPI.Business.Abstract;
using EDBackendAPI.Business.Concrete;
using EDBackendAPI.DataAccess.Abstract;
using EDBackendAPI.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDBackendAPI.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();
        }
    }
}
