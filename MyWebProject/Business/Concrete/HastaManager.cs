using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HastaManager : IHastaService
    {
        IHastaDal _hastadal;

        public HastaManager(IHastaDal hastadal)
        {
            _hastadal = hastadal;
        }

        public IResult Add(Hasta hasta)
        { if(hasta.HastaAdı.Length<2)
            {
                return new ErrorResult(Messages.HastaAdıGeçersiz);
            }
             _hastadal.Add(hasta);
            return new SuccessResult (Messages.HastaAdded);
        }

        public IDataResult<List<Hasta>> GetAll()
        {
            return new DataResult<List<Hasta>>(_hastadal.GetAll(),true,Messages.HastalarListelendi);
        }

        public IDataResult<List<Hasta>> GetAllByLaborantId(int id)
        {
            return new DataResult<List<Hasta>>(_hastadal.GetAll(p=>p.LaborantID==id),true,"id eşleşti");
        }

        public IDataResult<List<Hasta>> GetByHastaAdı(string ad)
        {

            return new DataResult<List<Hasta>>(_hastadal.GetAll(p => p.HastaAdı == ad), true, "ad eşleşti");
        }

        public IDataResult<List<Hasta>> GetByHastaSoyadı(string soyad)
        {
            return new DataResult<List<Hasta>>(_hastadal.GetAll(p => p.HastaSoyadı == soyad), true, "soyad eşleşti");
        }

        public IDataResult<List<Hasta>> GetByHastaTC(string TC)
        {
            return new DataResult<List<Hasta>>(_hastadal.GetAll(p => p.HastaTC == TC), true, "Tc eşleşti");
        }

        public IDataResult<List<HastaDetailDTO>> GetHastaDetails()
        {
            return new DataResult<List<HastaDetailDTO>>(_hastadal.GetHastaDetails(),true);
        }
    }


}
