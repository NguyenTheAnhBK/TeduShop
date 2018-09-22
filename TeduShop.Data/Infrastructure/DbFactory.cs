using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public class DbFactory:Disposable, IDbFactory//được kế thừa từ 1 interface và 1 class
    {
        private TeduShopDbContext dbContext;
        public TeduShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TeduShopDbContext());//nếu null sẽ khởi tạo new
        }
        protected override void DisposeCore()
        {
            if(dbContext!=null)
                dbContext.Dispose();
        }
    }
}
