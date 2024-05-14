using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RaporManager : IRaporService
    {
        IRaporDal _rapordal;

        public RaporManager(IRaporDal rapordal)
        {
            _rapordal = rapordal;
        }

        /*public List<Rapor> GetAllSortedByReportDate()
        {
            var allRaporlar = _rapordal.GetAll();
            return allRaporlar.OrderByDescending(r => r.RaporTarihi).ToList();
           
        }*/
// istediğimiz rapora tıkladığımızda detayları görüntülemek için oluşturdum 
        public Rapor GetById(int raporid)
        {
            return _rapordal.Get(r=>r.RaporID==raporid);
        }
    }

}
