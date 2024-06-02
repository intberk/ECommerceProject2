using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.Repositories.Concrete;
using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        private readonly ECommerce.DataAccessLayer.Context.Context _context;
        public EfCategoryDal(ECommerce.DataAccessLayer.Context.Context context) : base(context)
        {
            _context = context;
        }
        public List<Product> GetProductsWithCategoryId(int id)
        {

            var listedproducts = _context.Products.Where(x => x.CategoryId == id).ToList();
            return listedproducts;
        }

    }
}
