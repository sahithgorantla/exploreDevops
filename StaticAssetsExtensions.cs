using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace exploreDevops.Extensions
{
    public static class StaticAssetsExtensions
    {
        public static IApplicationBuilder MapStaticAssets(this IApplicationBuilder app)
        {
            // Your logic to map static assets
            app.UseStaticFiles();
            return app;
        }
    }

    public static class ControllerActionEndpointConventionBuilderExtensions
    {
        public static ControllerActionEndpointConventionBuilder WithStaticAssets(this ControllerActionEndpointConventionBuilder builder)
        {
            // Your logic to add static assets
            // builder.WithMetadata(new StaticAssetMetadata());
            return builder;
        }
    }
}
