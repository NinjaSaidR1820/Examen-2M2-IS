using AppCore.IService;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class BaseServices<T> : IServices<T>
    {
        private IModel<T> Model;

        protected BaseServices(IModel<T> model)
        {
            this.Model = model;
        }
        public void Add(T t)
        {
            Model.Add(t);
        }
    }
}
