using System.Collections.Generic;
using Course.WebApi.Models;

namespace Course.WebApi.Interfaces
{
    public interface IWeatherForecastRepo
    {
        IEnumerable<Employ> Read();
        IEnumerable<Employ> Update(Employ employ, int id);
    }
}
