
using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Laborant: IEntity
    {
        [Key]
        public int LaborantID { get; set; }
        public string LaborantAdı { get; set; }
        public string LaborantSoyadı { get; set; }
        public string HastaneKimlikNo { get; set; }
    }
}
