using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult  //IResult ta zaten success ve message var bir de data eklemek istiyorum. T her şey olabilir bu arada. farklı metodlarda farklı şeyler döndürürebiliriz
    {
        T Data { get; }
        //string BrandName { get; set; }
        //string ColorName { get; set; }
    }
}
