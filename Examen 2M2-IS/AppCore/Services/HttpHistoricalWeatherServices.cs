using AppCore.IService;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class HttpHistoricalWeatherServices<T> : IHttpHistoricalWeatherServices
    {
        IHttpHistoricalWeatherClient Client;

        public HttpHistoricalWeatherServices(IHttpHistoricalWeatherClient httpForeCastClient)
        {
            this.Client = httpForeCastClient;
        }

        public Task<OpenWeather> GetWeatherByCityNameAsync(double lat, double lon, string time)
        {
            return Client.GetWeatherByCityNameAsync(lat, lon, time);
        }
    }
}
