using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRaporService
    {
        
        //List<Rapor> GetAllSortedByReportDate();
        Rapor GetById(int raporid);
    }
}
