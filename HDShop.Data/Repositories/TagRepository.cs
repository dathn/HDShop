using HDShop.Data.Infrastructure;
using HDShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDShop.Data.Repositories
{
    public interface ITagRepository:IRepository<Tag>
    {

    }
    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
