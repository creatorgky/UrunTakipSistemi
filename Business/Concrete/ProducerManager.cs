using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProducerManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public ProducerManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveProduct(Person person)
        {
            if(_applicantService.checkPerson(person))
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " kişisine ürün verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " kişisine ürün verilemedi.");
            }
        }

    }
}
