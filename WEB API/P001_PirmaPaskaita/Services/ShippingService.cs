using Azure;
using Newtonsoft.Json;
using System.Net.Http;
using WebAppMSSQL.Models.DTO.ApiModels;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Services
{
    public class ShippingService : IShippingService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string warehouseLocation = "25.251531,54.700902";
        private readonly string apiKey = "5b3ce3597851110001cf6248c6894632ebb54bbbbb482c3f023530d7";

        public ShippingService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        //https://api.openrouteservice.org/geocode/search/structured?api_key=5b3ce3597851110001cf6248c6894632ebb54bbbbb482c3f023530d7&locality=Tokyo

        public async Task<string> GetKoordinates(string cityName)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("WebMapService");
            string endpoint = "/geocode/search/structured";
             CityLocation res = await httpClient.GetFromJsonAsync<CityLocation>(endpoint + "?api_key=" + apiKey + "&locality=" + cityName);
             string xy = res.features[0].geometry.coordinates[0].ToString() + "," + res.features[0].geometry.coordinates[1].ToString();
            return  xy;
        }


        //https://api.openrouteservice.org/v2/directions/driving-car?api_key=5b3ce3597851110001cf6248c6894632ebb54bbbbb482c3f023530d7&start=8.681495,49.41461&end=8.687872,49.420318

        public async Task<double> GetAtstumas(string cityLocation)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("WebMapService");
            string endpoint = "/v2/directions/driving-car";



            //Distance res2 = await httpClient.GetFromJsonAsync<Distance>(endpoint + "?api_key=" + apiKey + "&start=" + warehouseLocation + "&end=" + cityLocation);
            //float xy = res2.features[0].properties.summary.distance;

            //return 0.1;


            HttpResponseMessage res2 = await httpClient.GetAsync(endpoint + "?api_key=" + apiKey + "&start=" + warehouseLocation + "&end=" + cityLocation);
            if (res2.IsSuccessStatusCode)
            {
                var content = await res2.Content.ReadAsStringAsync();
                var distanceInKm = GetDistanceInMetersFromResponseString(content) / 1000;
                return distanceInKm;
            }
            return 0;


        }

        public double GetDistanceInMetersFromResponseString(string content)
        {
            string text = "summary\":{\"distance\":";
            var start = content.IndexOf(text) + text.Length;
            var end = content.IndexOf(",\"duration\"", start);
            var distanceInMeters = Convert.ToDouble(content.Substring(start, end - start));
            return distanceInMeters;
        }


       
        public async Task<double> GetKaina(double atstumas)
            {
             double pristatymoKaina = 0;

            if (atstumas < 50 )
            {
                return pristatymoKaina = 3;
            }

            if (atstumas >=50 && atstumas <= 150)
            {
                return pristatymoKaina = 5;
            }

            if (atstumas > 150)
            {
                return pristatymoKaina = 7;
            }

            return pristatymoKaina = 0;
            }













}
}
