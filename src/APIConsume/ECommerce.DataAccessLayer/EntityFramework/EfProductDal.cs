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
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly ECommerce.DataAccessLayer.Context.Context _context;
        public EfProductDal(ECommerce.DataAccessLayer.Context.Context context) : base(context)
        {
            _context = context;
        }

        public int GetProductCount()
        {

            var values = _context.Products.Count();
            return values;
        }
    }
}
