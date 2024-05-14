using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LaborantManager : ILaborantService
    {
        ILaborantDal _laborantdal;
        public LaborantManager(ILaborantDal laborantdal)
        {
            _laborantdal = laborantdal;
        }
        public IDataResult<List<Laborant>> GetAll()
        {
            return new DataResult<List<Laborant>>( _laborantdal.GetAll(),true,"laborantlar listelendi");
        }      

        public IDataResult<List<Laborant>> GetByLaborantSoyadı(string soyad)
        {
            return new DataResult<List<Laborant>>(_laborantdal.GetAll(p => p.LaborantSoyadı == soyad), true, "soyad eşleşti");
        }

       

        public IDataResult<List<Laborant>> GetByLabotrantAdı(string ad)
        {
            return new DataResult<List<Laborant>>(_laborantdal.GetAll(p => p.LaborantAdı == ad), true, "ad eşleşti");
        }
    }
}
