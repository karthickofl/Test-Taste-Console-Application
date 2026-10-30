using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Test_Taste_Console_Application.Constants;
using Test_Taste_Console_Application.Domain.Services;

namespace Test_Taste_Console_Application.Domain.Services
{
    ///<summary>
    /// A service to create the HttpClient. 
    ///</summary>
    public class HttpClientService
    {
        public HttpClient Client { get; }

        public HttpClientService(HttpClient client)
        {
            //The HTTP client is configured in the constructor.
            //Client = client;
            //Client.BaseAddress = new Uri(UriPath.BaseUri);
            //Client.DefaultRequestHeaders.Accept.Add(new
            //    MediaTypeWithQualityHeaderValue(HttpClientSettings.JsonType));

            Client = client;
            Client.BaseAddress = new Uri(UriPath.BaseUri);

            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            // API authentication // as of now hardcoded here , can me moved to env variable or config 
            const string apiToken = "b3217eba-ef78-4518-853a-c67b88755617";

            Client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", apiToken);
        }
    }
}

