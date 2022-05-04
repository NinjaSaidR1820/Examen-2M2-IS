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
    public class OpenWeatherServices : BaseServices<OpenWeather>, IWeatherService
    {
        IWeatherModel weather;
        public OpenWeatherServices(IWeatherModel model) : base(model)
        {
            this.weather = model;
        }
        public OpenWeather FindCity(string name)
        {
            return weather.FindCity(name);
        }
    }
}
