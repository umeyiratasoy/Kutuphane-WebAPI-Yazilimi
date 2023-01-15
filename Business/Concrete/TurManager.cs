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
    public class TurManager : ITurService
    {
        ITurDal _turDal;


        public TurManager(ITurDal turDal)
        {
            _turDal = turDal;
        }

        [CacheRemoveAspect("ITurService.Get")] //önbellek // sürekli veritabanına gitmemek için
        [SecuredOperation("gorevli")] // yetki
        [ValidationAspect(typeof(TurValidator))] // doğrulama
        public IResult Add(Tur tur)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _turDal.Add(tur);
            return new SuccessResult(Messages.TurEklendi);
        }

        
        [CacheRemoveAspect("ITurService.Get")]
        [SecuredOperation("gorevli")] // yetki
        public IResult Delete(Tur tur)
        {
            _turDal.Delete(tur);
            return new SuccessResult(Messages.TurSilindi);
        }


        
        [CacheAspect] //key,value 
        public IDataResult<List<Tur>> GetAll()
        {
            
            Thread.Sleep(5000);
            return new SuccessDataResult<List<Tur>>(_turDal.GetAll(), Messages.TurListelendi);

        }

        
        [CacheAspect]
        public IDataResult<Tur> GetById(int id)
        {
            
            Thread.Sleep(5000);
            return new SuccessDataResult<Tur>(_turDal.Get(t => t.TurId == id), Messages.İstenilenTurListelendi);
        }



        
        [CacheRemoveAspect("ITurService.Get")]
        [SecuredOperation("gorevli")] // yetki
        [ValidationAspect(typeof(TurValidator))] // doğrulama
        public IResult Update(Tur tur)
        {
            _turDal.Update(tur);
            return new SuccessResult(Messages.TurGuncellendi);
        }




    }
}
