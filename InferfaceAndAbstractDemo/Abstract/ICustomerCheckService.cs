using InferfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InferfaceAndAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
        System.Threading.Tasks.Task<MernisServiceReference.TCKimlikNoDogrulaResponse> CheckIfRealPerson(Customer customer);
    }
}
