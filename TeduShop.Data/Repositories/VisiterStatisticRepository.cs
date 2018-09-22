using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;

namespace TeduShop.Data.Repositories
{
    public interface IVisiterStatisticRepository
    {

    }
    public class VisiterStatisticRepository : RepositoryBase<VisiterStatistic>, IVisiterStatisticRepository
    {
        public VisiterStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
