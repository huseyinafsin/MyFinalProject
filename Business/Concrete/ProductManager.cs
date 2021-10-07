using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Constants;
using Core.Utilities.NewFolder.Results;
using Core.Utilities.Results;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour==20)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id),Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice<=max), Messages.ProductListed) ;
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            if (DateTime.Now.Hour==17)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(),Messages.ProductListed) ;
        }

        public IDataResult<Product> GetById(int productId)
        {
            //magic string
            return new SuccessDataResult<Product> (_productDal.Get(p => p.ProductId == productId), Messages.ProductListed);
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length<2)
            {
                return new  ErrorResult(Messages.ProductNameInvalid);
            }
            _productDal.Add(product);
            return  new SuccesResult(Messages.ProductAdded);
        }
    }
}
