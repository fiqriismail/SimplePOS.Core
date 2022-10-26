using Xunit;

namespace SimplePOS.Web.Api.Tests.Acceptance.Brokers;

[CollectionDefinition(nameof(ApiTestCollection))]
public class ApiTestCollection : ICollectionFixture<SimplePosApiBroker>
{
    
}