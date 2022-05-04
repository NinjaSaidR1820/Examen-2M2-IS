using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IService
{
    public interface IHttpServices
    {
        Task<OpenWeather> GetWeatherByCityNameAsync(double lat, double lon, string time);
    }
}
