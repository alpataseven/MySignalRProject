using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(Context context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new Context();
            var values = context.Products.Include(x=>x.Category).ToList(); //Kategoriyi ürünlere dahil etmek amacıyla yazıldı.
            return values;
        }
    }
}

/*
 var context = new Context();
            var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
            {
                ProductDescription = y.ProductDescription,
                ProductImageUrl = y.ProductImageUrl,
                ProductName = y.ProductName,
                ProductId = y.ProductId,
                ProductPrice = y.ProductPrice,
                ProductStatus = y.ProductStatus,
                CategoryName = y.Category.CategoryName
            }) //Kategoriyi ürünlere dahil etmek amacıyla yazıldı.
            return values.ToList();
 */
