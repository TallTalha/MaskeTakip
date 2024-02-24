using Business.Concrete;
using System.Security.Cryptography;

namespace Workspace
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.NationalIdentity = 0;
            person.FirstName = "TALHA BURAK";
            person.LastName =  "AYDIN";
            person.DateOfBirtYear = 2000;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);

        }

    }
}