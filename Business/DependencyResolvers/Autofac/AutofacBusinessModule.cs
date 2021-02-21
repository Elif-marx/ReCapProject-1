using System;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //bundan sonra ctor oluşturduğumuzda new lemiyoruz. burası bize bunu üretiyor.
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();//SingleInstange tek bir instance oluşturur.
            builder.RegisterType<EFCarDal>().As<ICarDal>().SingleInstance();
            //base.Load(builder);
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
