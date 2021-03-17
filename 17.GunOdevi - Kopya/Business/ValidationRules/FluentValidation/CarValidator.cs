using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);



            //yukarıda, ödevdeki kuralları yazdım.
            //RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(500).When(c => c.ColorId == 1); böyle bir kural da olabilir örneğin
            //RuleFor(c => c.CarName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");  //kendimiz buradaki listede olmayan bir kural yazmak istersek.örn.startwithA:nin altı kızarır, gnerate method de.

        }

        //private bool StartWithA(string arg)  //true döndürürsen kurala uygun false döndürürsen kural patlar
        //{
        //    return arg.StartsWith("A");  // A ile başlıyorsa üstteki kural çalışır, A ile başlamazsa orası patlar
        //}
    }
}
