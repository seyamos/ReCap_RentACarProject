using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{

    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))   //göndermeye çalıştığın validator type atanabiliyor mu? yani IValidator mu?  Yani buraya başka type ler yazılamasın diye bir defensive coding yazıyoruz.
            {
                throw new System.Exception("Bu bir doğrulam sınıfı değil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);         //Activator. --->Reflection Kodu  // Validator (şu an için Car validator örneğin)
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];              //tip (burada Car tipi. GenericArgümanların 0.inci elemanı, CarValidator'daki...1den fazla olabilirdi...)
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);      // metodun diyelim ki (invoc.add metodu bizim için)ADD'in argumanlarını gez, oradaki bir tip benim entity type ima eşitse -burada car , onu validate et.
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
