using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHastaService
    {//IDataResult kısmındaki T burada  IDataResult<List<Hasta>> GetAll();| List<Hasta> |bu oldu
        IDataResult<List<Hasta>> GetAll();
        IDataResult<List<Hasta>> GetAllByLaborantId(int id);
        IDataResult<List<HastaDetailDTO>> GetHastaDetails();
        IResult Add (Hasta hasta);
        IDataResult <List<Hasta>> GetByHastaAdı(string ad);
        IDataResult<List<Hasta>> GetByHastaSoyadı(string soyad);
        IDataResult<List<Hasta>> GetByHastaTC(string TC);

        //RESTFUL ---> HTTP (internet protokolü) (restful yapılarla internet protokaolü üzerinden iletişim kurarız)
        //WebAPI deki controller aslında entera basığımıza bizim ne yapacağımıza karar veren yapıdır 
    }
}
