using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; }

        public DataResult(T data,bool success,string message):base(success,message)
            //base dediğimiz resulttaki success ve message kısmını hemen dataresult için hem de result için iki sefer döndürmemesi
        {
            Data = data;
        }
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
    }
}
