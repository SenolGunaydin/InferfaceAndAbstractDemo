using InferfaceAndAbstractDemo.Abstract;
using InferfaceAndAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InferfaceAndAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public Task<TCKimlikNoDogrulaResponse> CheckIfRealPerson(Customer customer)
        {
            return null;
        }
    }
}
