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
    public class BaseServices<T> : IServices<T>
    {
        private IModel<T> Model;


        protected BaseServices(IModel<T> model)
        {
            this.Model = model;
        }


        void IServices<T>.Add(T t)
        {
            Model.Add(t);
        }

        bool IServices<T>.Delete(int id)
        {
            return Model.Delete(id);
        }

        List<T> IServices<T>.Read()
        {
            return Model.Read();
        }
    }
}
