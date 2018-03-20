using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HDShopDbContext dbContext;
        public HDShopDbContext Init()
        {
            return dbContext ?? (dbContext = new HDShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
