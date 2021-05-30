using InferfaceAndAbstractDemo.Abstract;
using InferfaceAndAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InferfaceAndAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public System.Threading.Tasks.Task<TCKimlikNoDogrulaResponse> CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt32(customer.NationalityId),customer.FirstName.ToUpper(),customer.LastName.ToUpper(),customer.DateOfBirth.Year);
        }
    }
}
