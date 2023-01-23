using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Haber> Haberler { get; }

        void SaveProduct(Haber p);
        void CreateProduct(Haber p);
        void DeleteProduct(Haber p); 

    }
}
