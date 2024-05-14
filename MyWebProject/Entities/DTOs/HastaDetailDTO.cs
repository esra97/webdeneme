using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    //DTO FARKLI TABLOLARIN SÜTUNLARINI BİRLEŞİTRMEYE YARAR
    //MESELA HASTA TABLOSUNDAN HASTA ADINI LABORANT TABLOSUNDAN HASTANE TC SİNİ BİRLİKTE YAZDIRMAK İSTERSEK KULLANANİLİRİZ
    //JOİN İŞLEMİNİ YAPAR ASLINDA
    //şimdilik öylesine ekleme yapıyorum projende gerekliyse kullanırsın 
    public class HastaDetailDTO : IDto
    {
        public string HastaTC { get; set; }
        public string HastaAdı { get; set; }
        public int LaborantID { get; set; }
        public string LaborantAdı { get; set; }
    }
}
