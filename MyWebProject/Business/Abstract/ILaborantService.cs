using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILaborantService
    {
        IDataResult<List<Laborant>>GetAll();      
        IDataResult<List<Laborant>> GetByLabotrantAdı(string ad);
        IDataResult<List<Laborant>> GetByLaborantSoyadı(string soyad);
    }
}
