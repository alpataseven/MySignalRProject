using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal :  IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories(); //Ürünleri kategori ile getirecek metot.
    }
}
