using Autofac;
using AutoFacCommon;
using System;
using System.Linq;
using System.Reflection;

namespace AutoFacInjectable.Infrastructure
{
    public static class AutofacDependecyBuilder
    {

        public static void DependencyBuilder()
        {
            // Create the builder with which components/services are registered.
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                                      .Where(t => t.GetCustomAttribute<InjectableAttribute>() != null)
                                      .AsImplementedInterfaces()
                                      .InstancePerRequest();

            // Build the container to finalize registrations
            // and prepare for object resolution.
            var container = builder.Build();

        }

    }
}