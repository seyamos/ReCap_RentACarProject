using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        public Result(bool success, string message):this(success) //this diyerek alttaki tek parametreliyi de çalıştır diyoruz.   //bu constructor yapısını şu 2 parametre için yaptık: true,araç eklendi şu yapı için soldakini buna göre dğştrdk :return new Result(true,"Araç Eklendi");
        {
            Message = message;                                      //Message { get; } teki get readonly dir ve readonly ler constructurda set edilebilir. o yüzden burada set edebiliyoruz. contrctr dışında set etmeyeceğiz zaten.constructor dışında set edilmesin diye de standartlaştırıyoruz burada aynı zamanda.
                                                                    //Success = success; bunu sildik gerek yok artık    
        }

        public Result(bool success)                                 //mesaj vermek istemezse de bu
        {                  
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
