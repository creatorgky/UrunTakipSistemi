using Business.Concrete;
using Entities.Concrete;

namespace WorkSpace
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new() {Id=1,NationalId=12244119172,FirstName="Hüseyin Gökay",LastName="Benian",DateOfBirthYear=2001};
            Person person2 = new() { Id = 2, NationalId = 123, FirstName = "Barış", LastName = "Benian", DateOfBirthYear = 1974 };
            Person person3 = new() { Id = 2, NationalId = 13873060750, FirstName = "Şenay", LastName = "Benian", DateOfBirthYear = 1963 };

            ProducerManager producerManager = new ProducerManager(new PersonManager());
            producerManager.GiveProduct(person3);

            Console.ReadLine();
        }

        string abc = "abc";
        string Y = "bca";

        static void SelamVer(string ad)
        {
            Console.WriteLine("Merhaba " + ad);
        }

      

    }
}

