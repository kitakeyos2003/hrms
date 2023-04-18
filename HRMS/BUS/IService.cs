using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.BUS
{
    public interface IService<E>
    {
        RestResponse<List<E>> GetAll();
        E Add(E e);
        bool Delete(int id);
        bool Update(E e);
    }
}
