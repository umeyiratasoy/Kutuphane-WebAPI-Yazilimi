using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Business.Concrete
{
    public class YazarManager : IYazarService
    {
        IYazarDal _yazarDal;

        public YazarManager(IYazarDal yazarDal)
        {
            _yazarDal = yazarDal;
        }

        [CacheRemoveAspect("IYazarService.Get")] //önbellek // sürekli veritabanına gitmemek için
        [SecuredOperation("gorevli")] // yetki
        [ValidationAspect(typeof(YazarValidator))] // doğrulama
        public IResult Add(Yazar yazar)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _yazarDal.Add(yazar);
            return new SuccessResult(Messages.YazarEklendi);
        }

        
        [CacheRemoveAspect("IYazarService.Get")]
        [SecuredOperation("gorevli")] // yetki
        public IResult Delete(Yazar yazar)
        {
            _yazarDal.Delete(yazar);
            return new SuccessResult(Messages.YazarSilindi);
        }


        [PerformanceAspect(5)] // Bu metod Performans gecikirse 5 saniye gecikirse bizi uyarır.
        [CacheAspect] //key,value 
        public IDataResult<List<Yazar>> GetAll()
        {
            // PerformanceAspect'i test etmek için fonksiyonu 500sn uyutuyoruz.
            Thread.Sleep(5000);
            return new SuccessDataResult<List<Yazar>>(_yazarDal.GetAll(), Messages.YazarListelendi);

        }

        [PerformanceAspect(10)]
        [CacheAspect]
        public IDataResult<Yazar> GetById(int id)
        {
            // PerformanceAspect'i test etmek için fonksiyonu 500sn uyutuyoruz.
            Thread.Sleep(5000);
            return new SuccessDataResult<Yazar>(_yazarDal.Get(o => o.YazarId == id), Messages.İstenilenYazarListelendi);
        }

        
        [SecuredOperation("gorevli")] // yetki
        [CacheRemoveAspect("IYazarService.Get")]
        [ValidationAspect(typeof(YazarValidator))] // doğrulama
        public IResult Update(Yazar yazar)
        {
            _yazarDal.Update(yazar);
            return new SuccessResult(Messages.YazarGüncellendi);
        }




    }
}
