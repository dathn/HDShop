using HDShop.Data.Infrastructure;
using HDShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDShop.Data.Repositories
{
    public interface IFooterRepository
    {

    }
    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        protected FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
