using AkademiPlusApi.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusApi.BusinessLayer.Abstract
{
    public interface ICustomerService : IGenericService<Customer>
    {
        int TGetCustomerCounts();
    }
}
