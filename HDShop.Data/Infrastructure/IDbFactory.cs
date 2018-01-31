using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        HDShopDbContext Init();
    }
}
