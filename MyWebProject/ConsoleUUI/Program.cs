
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
namespace ConsoleUII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HastaTest();
           // LabroantTest();

        }

       /* private static void LabroantTest()
        {
            LaborantManager laborantmanager = new LaborantManager(new EfLaborantDal());
            foreach (var laborant in laborantmanager.GetAll())
            {
                Console.WriteLine(laborant.LaborantSoyadı);
            }
        }*/

        private static void HastaTest()
        {
            HastaManager hastamanager = new HastaManager(new EfHastaDal());
            var result = hastamanager.GetAll();
            if (result.Success == true)
            {
                foreach (var hasta in result.Data)
                {
                    Console.WriteLine(hasta.HastaAdı );
           
                }
            }
           
        }
    }
}