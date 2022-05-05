using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IService
{
    public interface IHistorticalWeatherServices :  IServices<OpenWeather>
    {
        OpenWeather GetById(int id);
        void Update(OpenWeather t);
    }
}
