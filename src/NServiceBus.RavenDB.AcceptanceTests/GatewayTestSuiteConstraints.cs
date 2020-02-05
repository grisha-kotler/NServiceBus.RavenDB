﻿namespace NServiceBus.Gateway.AcceptanceTests
{
    using NServiceBus.AcceptanceTesting.Support;
    using NServiceBus.Configuration.AdvancedExtensibility;
    using System.Threading.Tasks;

    public partial class GatewayTestSuiteConstraints
    {
        public Task ConfigureDeduplicationStorage(string endpointName, EndpointConfiguration configuration, RunSettings settings)
        {
            var documentStore = ConfigureEndpointRavenDBPersistence.GetDocumentStore();

            databaseName = documentStore.Database;


            configuration.UsePersistence<RavenDBPersistence, StorageType.GatewayDeduplication>()
                .DoNotSetupDatabasePermissions()
                .SetDefaultDocumentStore(documentStore);

            var gatewaySettings = configuration.Gateway();
            configuration.GetSettings().Set(gatewaySettings);

            return Task.FromResult(false);
        }

        public Task Cleanup()
        {
            return ConfigureEndpointRavenDBPersistence.DeleteDatabase(databaseName);
        }

        string databaseName;
    }
}