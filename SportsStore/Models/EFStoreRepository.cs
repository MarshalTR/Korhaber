using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private readonly StoreDbContext _context;
        public EFStoreRepository(StoreDbContext context)
        {
            _context = context;
        }
        public IQueryable<Haber> Haberler => _context.Haberler;

        public void CreateProduct(Haber p)
        {
            _context.Add(p);
            _context.SaveChanges();
        }

        public void DeleteProduct(Haber p)
        {
            _context.Remove(p);
            _context.SaveChanges();
        }

        public void SaveProduct(Haber p)
        {
            _context.SaveChanges();
        }
    }
}
