using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IService
{
    public interface IServices<T>
    {

        void Add(T t);
    }
}
