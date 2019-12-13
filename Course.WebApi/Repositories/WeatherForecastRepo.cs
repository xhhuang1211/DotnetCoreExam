//using System.Collections.Generic;
//using System.Linq;
//using Course.WebApi.Interfaces;
//using Course.WebApi.Models;
//using Course.WebApi.Repositories;
//
//namespace Course.WebApi.Services
//{
//    public class WeatherForecastRepo :IWeatherForecastRepo
//    {
//        private readonly EmployDbContext _context;
//        public WeatherForecastRepo(EmployDbContext context)
//        {
//            _context = context;
//        }
//
//        public IEnumerable<Employ> Read()
//        {
//            return _context.Employs.ToArray();
//        }
//
//        public IEnumerable<Employ> Update(Employ employ, int id)
//        {
//            var item = _context.Employs.SingleOrDefault(x => x.Id == id);
//            if (item != null)
//            {
//                item.Summary = employ.Summary;
//                item.TemperatureC = employ.TemperatureC;
//                item.Date = employ.Date;
//                _context.SaveChanges();
//            }
//            return _context.Employs.ToArray();
//        }
//
//        public IEnumerable<Employ> Delete(int id)
//        {
//            var item = _context.Employs.SingleOrDefault(x => x.Id == id);
//            if (item != null)
//            {
//                _context.Employs.Remove(item);
//                _context.SaveChanges();
//            }
//            return _context.Employs.ToArray();
//        }
//    }
//}
