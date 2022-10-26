using System;
using FluentAssertions;
using SimplePOS.Web.Api.Tests.Acceptance.Brokers;
using Xunit;

namespace SimplePOS.Web.Api.Tests.Acceptance.APIs.Homes
{
    [Collection(nameof(ApiTestCollection))]
    public class HomeApiTests
    {
        private readonly SimplePosApiBroker simplePosApiBroker;

        public HomeApiTests(SimplePosApiBroker simplePosApiBroker)
        {
            this.simplePosApiBroker = simplePosApiBroker;
        }

        [Fact]
        public async Task ShouldReturnHomeMessageAsync()
        {
            // given
            string expectedMessage =
                "The stuff you looking is not here, it's somewhere else!";

            // when
            string actualMessage =
                await this.simplePosApiBroker.GetHomeMessageAsync();

            // then
            actualMessage.Should().BeEquivalentTo(expectedMessage);
        }
    }
}

