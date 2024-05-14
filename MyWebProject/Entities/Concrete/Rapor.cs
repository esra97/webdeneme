
using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rapor: IEntity
    {
        [Key]
        public int RaporID { get; set; }
        public int LaborantID { get; set; }
        public string HastaTC { get; set; }
        public int DosyaNO { get; set; }
        public string HastaAdı { get; set; }
        public string HastaSoyadı { get; set; }
        public string TanıBaşlığı { get; set; }
        public string TanıDetayları { get; set; }
        public DateTime RaporTarihi { get; set; }
        public string RaporFotoğrafı { get; set; }

    }
}
