using Core.Entities;
using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHastaDal : EfEntityRepositoryBase<Hasta, SqlContext>, IHastaDal
    {
        public List<HastaDetailDTO> GetHastaDetails()
        {
          using(SqlContext context = new SqlContext())
            {
               var result = from h in context.Hastalar
                            join l in context.Laborantlar
                             on h.LaborantID equals l.LaborantID
                            select new HastaDetailDTO { HastaAdı = h.HastaAdı, HastaTC = h.HastaTC, LaborantAdı = l.LaborantAdı };

                return result.ToList();
            }
        }
    }
}
