# NServiceBus.RavenDB

The official [NServiceBus](https://github.com/Particular/NServiceBus) persistence implementation for [RavenDB.](https://ravendb.net/)

Learn more about NServiceBus.RavenDB through our [documentation.](http://docs.particular.net/nservicebus/ravendb/)

If you are interested in contributing, please follow the instructions [here.](https://github.com/Particular/NServiceBus/blob/develop/CONTRIBUTING.md)

## Running the tests

Running the tests requires RavenDB 5.2 and two environment variables. One named `CommaSeparatedRavenClusterUrls` containing the URLs, separated by commas, to connect to a RavenDB cluster to run cluster-wide transaction tests. The second one named `RavenSingleNodeUrl` containing the URL of a single node RavenDB instance to run non-cluster-wide tests. The tests can be run with RavenDB servers hosted on a Docker container.
