using Newtonsoft.Json;
using System.Net.Http;
using WebAppMSSQL.Models.DTO.ApiModels;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Services
{
    public class ShippingService : IShippingService
    {


        private readonly IHttpClientFactory _httpClientFactory;
        public ShippingService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        //https://api.openrouteservice.org/geocode/search/structured?api_key=5b3ce3597851110001cf6248c6894632ebb54bbbbb482c3f023530d7&locality=Tokyo


        public async Task<CityLocation> GetKoordinates(string locality)
        {
            var httpClient = _httpClientFactory.CreateClient("WebMapService");
            var apiKey = "5b3ce3597851110001cf6248c6894632ebb54bbbbb482c3f023530d7";
            var endpoint = "/geocode/search/structured";
            var res = await httpClient.GetFromJsonAsync<CityLocation>(endpoint + "?" + "api_key=" + apiKey + "&locality=" + locality);
            return res;
           

         
        }



























    }
}
