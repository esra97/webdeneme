using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {// burada base dediğimiz kısım resulttır
     // resulttaki constructerların parametrelerini kullanabiliriz
     // succes true olursa bunu false olursa da errorresult kısmını kullanırız
        public SuccessResult(string message) : base(true,message)
        {
        }
        public SuccessResult() : base(true)
        {

        }
    }
}
