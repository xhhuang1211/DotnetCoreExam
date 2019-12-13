using System.Collections.Generic;
using System.Linq;
using Course.WebApi.Interfaces;
using Course.WebApi.Models;

namespace Course.WebApi.Repositories
{
    public class EmployRepo : IEmployRepo
    {
        private readonly EmployDbContext _context;

        public EmployRepo(EmployDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employ> Read()
        {
            return _context.Employs.ToArray();
        }

        public IEnumerable<Employ> Update(Employ employ, int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            var item = _context.Employs.SingleOrDefault(x => x.Id == id);
            if (item != null)
            {
                _context.Employs.Remove(item);
                _context.SaveChanges();
            }
        }

    }
}
