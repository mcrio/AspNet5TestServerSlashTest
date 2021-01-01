using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using WebApplication;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test()
        {
            var factory = new WebApplicationFactory<Startup>();
            HttpClient client = factory.CreateClient();

            var request = new HttpRequestMessage(HttpMethod.Get, "/api/foo%2Fbar");
            HttpResponseMessage response = await client.SendAsync(request);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}