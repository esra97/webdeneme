
using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Hasta: IEntity
    {
        [Key]
        public string HastaTC { get; set; }
        public string HastaAdı { get; set; }
        public string HastaSoyadı { get; set; }
        public int LaborantID { get; set; }


    }
}
