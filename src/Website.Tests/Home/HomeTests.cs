using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNet.TestHost;
using Xunit;
// ReSharper disable ConsiderUsingConfigureAwait

namespace Website.Tests.Home
{
    public class HomeTests
    {
        private readonly HttpClient _client;
 
        public HomeTests()
        {
            var server = new TestServer(TestServer.CreateBuilder()
                .UseStartup<TestStartup>());

            _client = server.CreateClient();
        }

        [Fact]
        public async Task Index_returns_page()
        {
            var response = await _client.GetAsync("/");
            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            Assert.NotEmpty(responseString);
        }
    }
}