using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class BinaryHistoricalWeatherRepository : IHistoricalWeatherModel
    {

        private RAFContext Context;
        private const int Size = 0;


        public BinaryHistoricalWeatherRepository()
        {
            this.Context = new RAFContext("", Size);
        }

        public void Add(OpenWeather t)
        {
            try
            {
                Context.Create(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                return Context.Delete(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OpenWeather GetById(int id)
        {
            try
            {
                return Context.Get<OpenWeather>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<OpenWeather> Read()
        {
            try
            {
                return Context.GetAll<OpenWeather>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(OpenWeather t)
        {
            try
            {
                Context.Update(t);
            }
            catch
            {
                throw;
            }
        }
    }
}
