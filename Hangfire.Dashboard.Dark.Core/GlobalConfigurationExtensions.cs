using System;
using System.Reflection;

using Hangfire.Dashboard.Dark.Core.Support;

namespace Hangfire.Dashboard.Dark.Core
{
    /// <summary>
    /// Provides extension methods to setup Hangfire.Dashboard.Dark
    /// </summary>
    public static class GlobalConfigurationExtensions
    {
        /// <summary>
        /// Configures Hangfire to use the dark dashboard theme
        /// </summary>
        /// <param name="configuration">Global configuration</param>
        public static IGlobalConfiguration UseDarkDashboard(this IGlobalConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            // register dispatchers for CSS
            var assembly = typeof(GlobalConfigurationExtensions).GetTypeInfo().Assembly;
            DashboardRoutes.Routes.Append("/css[0-9]+", new EmbeddedResourceDispatcher(assembly, "Hangfire.Dashboard.Dark.Core.Resources.style.css"));

            return configuration;
        }
    }
}
