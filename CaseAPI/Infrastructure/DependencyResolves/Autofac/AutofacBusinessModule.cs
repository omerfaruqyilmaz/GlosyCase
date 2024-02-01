using Autofac;
using Autofac.Extras.DynamicProxy;
using CaseAPI.Core.Utilities.Interceptors;
using CaseAPI.Infrastructure.Abstact.Query;
using CaseAPI.Infrastructure.Abstact.Service;
using CaseAPI.Infrastructure.Concrete.Query;
using CaseAPI.Infrastructure.Concrete.Service;
using Castle.DynamicProxy;
using System.Reflection;
using Module = Autofac.Module;


namespace CaseAPI.Infrastructure.DependencyResolves.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductQuery>().As<IProductQuery>().SingleInstance();
            builder.RegisterType<ProductService>().As<IProductService>().SingleInstance();



            Assembly assembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
