using InferfaceAndAbstractDemo.Abstract;
using InferfaceAndAbstractDemo.Adapters;
using InferfaceAndAbstractDemo.Concrete;
using InferfaceAndAbstractDemo.Entities;
using System;

namespace InferfaceAndAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            baseCustomerManager.Save(new Customer { FirstName = "Şenol", LastName = "Günaydın", DateOfBirth = new DateTime(1995, 4, 11), NationalityId = "123456987" });

            Console.ReadLine();
        }
    }
}
