using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
       
        
    }
}
