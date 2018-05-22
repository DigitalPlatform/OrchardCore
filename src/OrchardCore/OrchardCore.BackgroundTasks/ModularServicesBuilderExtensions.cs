using OrchardCore.Modules;

namespace OrchardCore.BackgroundTasks
{
    public static class ModularServicesBuilderExtensions
    {
        /// <summary>
        /// Adds tenant level background tasks services.
        /// </summary>
        public static ModularServicesBuilder AddBackgroundTasks(this ModularServicesBuilder builder)
        {
            builder.Services.ConfigureTenantServices((collection) =>
            {
                collection.AddBackgroundTasks();
            });

            return builder;
        }
    }
}