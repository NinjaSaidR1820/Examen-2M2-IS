using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IHttpHistoricalWeatherClient
    {
        Task<OpenWeather> GetWeatherByCityNameAsync(double lat, double lon, string time);
    }
}
