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
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Business.Concrete
{
    public class EmanetManager : IEmanetService
    {
        IEmanetDal _emanetDal;

        public EmanetManager(IEmanetDal emanetDal)
        {
            _emanetDal = emanetDal;
        }

        [CacheRemoveAspect("IEmanetService.Get")] //önbellek // sürekli veritabanına gitmemek için
        [SecuredOperation("gorevli")] // yetki
        [ValidationAspect(typeof(EmanetValidator))] // doğrulama
        public IResult Add(Emanet emanet)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _emanetDal.Add(emanet);
            return new SuccessResult(Messages.EmanetEklendi);
        }

        
        [SecuredOperation("gorevli")] // yetki
        [CacheRemoveAspect("IEmanetService.Get")]
        public IResult Delete(Emanet emanet)
        {
            _emanetDal.Delete(emanet);
            return new SuccessResult(Messages.EmanetSilindi);
        }


        
        [CacheAspect] //key,value 
        public IDataResult<List<Emanet>> GetAll()
        {
           

            return new SuccessDataResult<List<Emanet>>(_emanetDal.GetAll(), Messages.EmanetListelendi);

        }

        
        [CacheAspect]
        public IDataResult<Emanet> GetById(int id)
        {
            
            Thread.Sleep(5000);
            return new SuccessDataResult<Emanet>(_emanetDal.Get(o => o.KitapId == id), Messages.İstenilenEmanetListelendi);
        }

        public IDataResult<List<EmanetDetayDto>> GetEmanetDetaylar()
        {
            return new SuccessDataResult<List<EmanetDetayDto>>(_emanetDal.GetEmanetDetaylar());
        }

        
        [SecuredOperation("gorevli")] // yetki
        [CacheRemoveAspect("IEmanetService.Get")]
        [ValidationAspect(typeof(EmanetValidator))] // doğrulama
        public IResult Update(Emanet emanet)
        {
            _emanetDal.Update(emanet);
            return new SuccessResult(Messages.EmanetGüncellendi);
        }
    }
}
