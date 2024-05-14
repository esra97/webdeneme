using Microsoft.Identity.Client.TelemetryCore.TelemetryClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{//IResultta mesaj işlem sonucu içeriyordu fakat data içermiyordu bunda data da içerecek
 //şöyle düşün ıresult voidler içindi bu liste için yani değer döndüren şeyler için kullanırlır
 //T yazma sebebimiz biri hasta döndürüyor diğeri hastalistesi biri rapor döndüryor bu yüzden tipi kendimiz belirlicesz 
 //IResulttı implemente etme nedenimiz succes ve mesaj kısmının aynı olacak olması
    public interface IDataResult<T> :IResult
    {
        T Data { get; }
    }
}
