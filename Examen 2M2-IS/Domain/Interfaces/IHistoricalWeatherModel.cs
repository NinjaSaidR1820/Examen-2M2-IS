using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IHistoricalWeatherModel : IModel<OpenWeather>
    {
        OpenWeather GetById(int id);
        void Update(OpenWeather t);

    }
}
