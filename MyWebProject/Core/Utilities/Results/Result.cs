using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       
        public Result(bool success, string message) : this(success)
        {
            //oluştuduğumuz constructer sayesşnde mesaj ve succes kısmını set edebiliyoruz 
            //burada   Success = success; bu yapıyı yazmıcaz çünkü altta yzıyor bunun için this(success) yapısını oluşturduk
            //yani this dediğimiz result clasın bu constructer çalıştığında result sınıfındaki succes kısmıds çalışsın istiyoruz 
            Message = message;
          
        }
        public Result(bool success)
        {
            //oluştuduğumuz constructer sayesşnde mesaj vermeyen sadece işlemin başarılı olup olmadığını gösteren bir yapı oluşturduk 
            //overloading yapmış olduk 
           
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
