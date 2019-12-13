using System.Collections.Generic;
using Course.WebApi.Models;

namespace Course.WebApi.Interfaces
{
    public interface IEmployRepo
    {
        IEnumerable<Employ> Read();
        IEnumerable<Employ> Update(Employ employ, int id);
        void Delete(int id);
        void Insert(Employ employ);
    }
}
