using EDBackendAPI.Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using EDBackendAPI.Core.CrossCuttingConcerns.Caching;
using EDBackendAPI.Core.CrossCuttingConcerns.Caching.Microsoft;

namespace EDBackendAPI.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddMemoryCache();
            //Not:MemoryCacheManager kısmı yarın Redis yapılırsa sistem redise geçmiş olur
            services.AddSingleton<ICacheManager, MemoryCacheManager>();
        }
    }
}
