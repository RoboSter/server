using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using Utilities.Helpers;

namespace Utilities.Container
{
    public class AutoRegistrationModule :  Autofac.Module
    {
        private readonly Assembly assembly;
        private readonly List<Type> excludedTypes = new List<Type>();

        public AutoRegistrationModule(Assembly assembly)
        {
            this.assembly = assembly;
        }

        public AutoRegistrationModule ExcludeTypes(params Type[] types)
        {
            excludedTypes.AddRange(types);
            return this;
        }
        
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(assembly)
                .Where(type => !type.HasAttribute<PreventAutoRegistrationAttribute>())
                .Where(type => !excludedTypes.Contains(type))
                .AsImplementedInterfaces();
        }
    }
}