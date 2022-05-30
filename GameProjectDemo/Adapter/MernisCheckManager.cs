using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using Mernis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Adapter
{
    public class MernisCheckManager : ICustomerCheckService
    {
        public async Task<bool> CheckIfRealPerson(Customer customer)
        {
            var client = new Mernis.KPSPublicSoapClient(Mernis.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(),customer.LastName.ToUpper(), customer.DateOfBirth.Year);
            var result = response.Body.TCKimlikNoDogrulaResult;
            return result;
            

        }
    }
}
