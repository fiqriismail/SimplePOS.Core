using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;

namespace SimplePOS.Web.Api.Tests.Acceptance.Brokers;

public partial class SimplePosApiBroker
{
    private readonly WebApplicationFactory<Program> webApplicationFactory;
    private readonly HttpClient httpClient;
    private readonly IRESTFulApiFactoryClient apiFactoryClient;

    public SimplePosApiBroker()
    {
        this.webApplicationFactory = new WebApplicationFactory<Program>();
        this.httpClient = this.webApplicationFactory.CreateClient();
        this.apiFactoryClient = new RESTFulApiFactoryClient(this.httpClient);
    }
    
    
}