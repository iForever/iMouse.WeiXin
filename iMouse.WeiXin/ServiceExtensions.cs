using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace iMouse.WeiXin
{
    public static class ServiceExtensions
    {

        public static WebApplication UseWeiXinInject(this WebApplication app)
        {
            ServiceProvider.RootServices = app.Services;

            return app;
        }

        public static IServiceCollection AddWeiXinCacheProviders<T>(this IServiceCollection services) where T : class, ICacheProvider
        {
            services.AddDistributedMemoryCache();
            services.AddTransient<ICacheProvider, T>();
            return services;
        }
        public static IServiceCollection AddWeiXinDefaultCacheProviders(this IServiceCollection services)
        {
            services.AddWeiXinCacheProviders<DefaultCacheProvider>();
            return services;
        }


        public static IServiceCollection AddWeiXinServices(this IServiceCollection services)
        {
            services.AddOptions<WeiXinOptions>().BindConfiguration("WeiXinOptions");
            services.AddTransient<ICredentialService, CredentialService>();
            services.AddTransient<ISubscribeMessageService, SubscribeMessageService>();

            services.AddTransient<IOpenApiService, OpenApiService>();

            services.AddOfficalServices();
            services.AddMiniProgramServices();

            return services;
        }

        private static IServiceCollection AddOfficalServices(this IServiceCollection services)
        {
            services.AddTransient<IJSInteropService, JSInteropService>();
            services.AddTransient<IOfficalUserService, OfficalUserService>();
            services.AddTransient<IWebAuthorizeService, WebAuthorizeService>();
            return services;
        }

        private static IServiceCollection AddMiniProgramServices(this IServiceCollection services)
        {
            services.AddTransient<IAnalysisService, AnalysisService>();
            services.AddTransient<IAuthorizeService, AuthorizeSerivce>();
            services.AddTransient<ILiveService, LiveService>();
            services.AddTransient<ILiveGoodService, LiveGoodService>();
            services.AddTransient<ILiveRoleService, LiveRoleService>();
            services.AddTransient<ILiveSubscribeService, LiveSubscribeService>();
            services.AddTransient<IMessageService, MessageService>();
            services.AddTransient<IQRCodeLinkService, QRCodeLinkService>();
            services.AddTransient<ISecurityService, SecurityService>();
            services.AddTransient<IUserService, UserService>();
            return services;
        }
    }
}
