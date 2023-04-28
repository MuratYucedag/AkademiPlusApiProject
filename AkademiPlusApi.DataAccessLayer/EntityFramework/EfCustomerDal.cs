using AkademiPlusApi.DataAccessLayer.Abstract;
using AkademiPlusApi.DataAccessLayer.Concrete;
using AkademiPlusApi.DataAccessLayer.Repositories;
using AkademiPlusApi.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusApi.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public int GetCustomerCounts()
        {
            var context = new Context();
            return context.Customers.Count();
        }
    }
}
